# Ternary.Engine

> **Beta** — features and APIs are subject to change.

Ternary.Engine is a .NET 8 framework for building robust, auditable workflows against databases. It provides first-class support for managing Entity Framework DbContexts, scaffolding Worker Service projects, and installing those services as Windows Services — all from a single CLI.

## Core Concepts

### Worker Services
Each service follows a consistent pattern built around three types:

| Type | Role |
|---|---|
| `WorkerBase<TWorker, TService>` | Hosted background worker; entry point for a workflow run |
| `ServiceBase<TDbContext>` | Manages the DbContext and exposes it to runners |
| `WorkRunner` | Processes individual `WorkItem`s produced by a work batch |

### Auditable Workflow Pipeline
The framework is designed around full observability:

1. **`OnBeforeExecute`** — staging hook on the worker. Use this to ingest files, seed data, or create work batches before processing begins.
2. **Work Batches** — a set of `WorkItem`s queued for processing. Items are processed through your `WorkRunner.RunItemAsync` implementation.
3. **Observability** — every batch and item is tracked, giving you a full audit trail of what ran, when, and with what result.

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (or compatible EF Core provider)

### Install the Templates

```shell
dotnet new install Ternary.Engine.Templates
```

For local development iteration:

```shell
dotnet new uninstall Ternary.Engine.Templates
dotnet new install ./Ternary.Engine.Templates/
```

### Scaffold a New Worker Service

Via `dotnet new`:

```shell
dotnet new ternary-workservice --name Export --output ../Ternary.Engine.Export
```

Via the `engine` CLI:

```shell
engine projects create --name Export
engine projects create --name Report --type Custom --output ../Ternary.Engine.Report --solution ./Ternary.Engine.sln
```

### Wire Up the Worker

Each scaffolded service generates a `Program.cs`, worker, service, and runner. Register your dependencies and run:

```csharp
var config = AppConfiguration.Create(args, (config, builder) =>
{
    builder.Services.AddSingleton<ExampleService>();
    builder.Services.AddHostedService<ExampleWorker>();
    return builder;
});

await config.Build().RunAsync();
```

### Implement Your Worker

Override `OnBeforeExecute` to ingest files and create work batches, then implement `RunItemAsync` in your runner to process each item:

```csharp
public class ExampleWorker : WorkerBase<ExampleWorker, ExampleService>
{
    public override WorkerType WorkerType => WorkerType.Extract;

    public override async Task OnBeforeExecute(IRunContext context)
    {
        // Ingest files, extract data objects, create work batches
    }
}

public class ExampleRunner : WorkRunner
{
    public override async Task<WorkItem> RunItemAsync(WorkItem item, IWorkContext context)
    {
        // Process each work item with full observability
    }
}
```

## CLI Reference

The `engine` CLI manages DbContexts, projects, and Windows Services.

```shell
engine projects create --name <ServiceName>
engine projects create --name <ServiceName> --type Custom --output <path> --solution <sln>
```

## NuGet Package Distribution

Pack the templates for distribution:

```shell
dotnet pack Ternary.Engine.Templates/Ternary.Engine.Templates.csproj -o ./nupkg
```

## Project Structure

```
Ternary.Engine/                  # CLI host (engine command)
Ternary.Engine.ExampleService/   # Reference implementation
Ternary.Engine.Templates/        # dotnet new templates
```

## Status

This project is in **beta**. More features are planned. Feedback and contributions are welcome.

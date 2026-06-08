# Ternary.Engine CLI Documentation

This document provides comprehensive documentation for all CLI commands available in the Ternary.Engine application.

## Table of Contents

- [Getting Started](#getting-started)
- [Command Structure](#command-structure)
- [Database Commands](#database-commands)
- [Context Commands](#context-commands)
- [Migration Commands](#migration-commands)
- [Service Commands](#service-commands)
- [Template Commands](#template-commands)
- [Service Mode](#service-mode)
- [Examples](#examples)
- [Troubleshooting](#troubleshooting)

## Getting Started

The Ternary.Engine CLI provides a suite of commands for managing database contexts, migrations, Windows services, and project templates. Commands follow a hierarchical structure with subcommands for specific operations.

### Basic Syntax

```bash
./engine <command> <subcommand> [options] [arguments]
```

### Special Flags

- `_project` - Enables project-specific commands (migrations, templates)
- `run-service` - Runs the application in service mode

## Command Structure

The CLI is organized into the following command groups:

- `database` - Database management and connectivity
- `contexts` - DbContext operations
- `migrations` - Entity Framework Core migration management (requires `_project` flag)
- `services` - Windows service instance management
- `templates` - Project scaffolding and templates (requires `_project` flag)
- `run-service` - Execute as a hosted service

---

## Database Commands

Commands for testing connection, creating, or modifying the database.

### `database list`

List all available DbContext types and test their instantiation.

```bash
./engine database list
```

**Description:** Discovers and validates all DbContext classes in the application.

---

### `database connect`

Test database connectivity.

```bash
./engine database connect
```

**Description:** Tests the connection to the database using the WorkDbContext. Includes a 30-second timeout for connection attempts.

---

### `database script`

Generate SQL creation scripts for all database contexts.

```bash
./engine database script
```

**Description:** Generates SQL scripts that can be used to create the database schema for all registered DbContext types. Scripts are saved to the output directory.

---

### `database update`

Run all pending migrations across all contexts.

```bash
./engine database update
```

**Description:** Applies any pending EF Core migrations to the database for all registered contexts.

---

### `database create`

Create database tables and run pending migrations.

```bash
./engine database create
```

**Description:** Creates all tables if they don't exist and applies pending migrations. **Warning:** Drops existing schema before creation.

---

### `database drop`

Drop the migration schema from the database.

```bash
./engine database drop
```

**Description:** Removes all tables and constraints from the 'mig' schema and drops the `__EFMigrationsHistory` table.

**⚠️ Warning:** This is a destructive operation. Use with caution.

---

## Context Commands

Commands for DbContext-related operations.

### `contexts list`

List available contexts and test their health.

```bash
./engine contexts list
```

**Description:** Displays a table of all available DbContext types with their health status (Healthy/Unhealthy).

---

### `contexts migrations`

Manage migrations for a specific context.

```bash
./engine contexts migrations <context> <command> [options]
```

**Arguments:**
- `<context>` - Name of the DbContext
- `<command>` - Command to execute: `add`, `update`, `remove`, or `list`

**Options:**
- `-p, --project <path>` - Sets the project to use (defaults to working directory)
- `-n, --migrationname <name>` - Migration name (required for 'remove' command)
- `-f, --force` - Force revert if migration has been applied (for 'remove' command)

**Examples:**

```bash
# Add a migration
./engine contexts migrations MyDbContext add -p ./MyProject

# List migrations
./engine contexts migrations MyDbContext list

# Remove a migration
./engine contexts migrations MyDbContext remove -n MyMigration -f
```

---

## Migration Commands

Commands for creating, removing, and generating scripts for Entity Framework Core migrations.

**Note:** These commands require the `_project` flag to be enabled.

### `migrations add`

Add a new migration for a specific context.

```bash
./engine _project migrations add [options]
```

**Options:**
- `-c, --context <name>` - Name of the DbContext
- `-p, --project <path>` - Path to the project directory (defaults to current directory)

**Description:** Scaffolds a new migration and saves the migration files (migration, metadata, and snapshot).

---

### `migrations list`

List all migrations for a specific context.

```bash
./engine _project migrations list [options]
```

**Options:**
- `-c, --context <name>` - Name of the DbContext (optional - lists all if omitted)
- `-p, --project <path>` - Path to the project directory

**Description:** Displays pending and applied migrations for the specified context or all contexts.

---

### `migrations remove`

Remove the most recent migration for a specific context.

```bash
./engine _project migrations remove -n <migration-name> [options]
```

**Arguments:**
- `-n, --migrationname <name>` - Name of the migration to remove

**Options:**
- `-c, --context <name>` - Name of the DbContext
- `-p, --project <path>` - Path to the project directory
- `-f, --force` - Revert the migration if it has been applied to the database

**Description:** Removes migration files and optionally reverts database changes.

---

### `migrations script`

Generate a SQL script from migrations.

```bash
./engine _project migrations script -o <output-file> [options] [arguments]
```

**Options:**
- `-o, --output <file>` - The file to write the SQL script to
- `-c, --context <name>` - Name of the DbContext
- `-p, --project <path>` - Path to the project directory
- `-i, --idempotent` - Generate an idempotent script that can be used on databases at any migration state

**Arguments:**
- `<start>` - Starting migration (defaults to '0' - initial database)
- `<end>` - Target migration (defaults to the last migration)

**Examples:**

```bash
# Generate script for all migrations
./engine _project migrations script -o migrate.sql -c MyDbContext

# Generate idempotent script
./engine _project migrations script -o migrate.sql -c MyDbContext -i

# Generate script between specific migrations
./engine _project migrations script -o migrate.sql -c MyDbContext Migration1 Migration5
```

---

## Service Commands

Commands for creating and managing Windows service instances.

### `services assist`

Interactive wizard for service operations.

```bash
./engine services assist
```

**Description:** Launches an interactive menu to select from: List, Create, Update, or Remove service operations.

---

### `services list`

List all registered services in the environment.

```bash
./engine services list
```

**Description:** Displays a table of all services with their ID, name, machine name, directory, and status (Active, Inactive, Disabled, Missing).

---

### `services create`

Create a new Windows service instance.

```bash
./engine services create -i <source-directory> [options]
```

**Options:**
- `-i, --sourcedirectory <path>` - Input source service directory containing the executable
- `-o, --destinationdirectory <path>` - Output destination directory for service instance (default: `C:\MigrationServices`)
- Additional options for service name, description, and start mode (prompted interactively in assist mode)

**Description:** Copies service files from source directory, creates a new service instance, and registers it as a Windows service.

**Interactive Options (via assist):**
- Service name (unique identifier)
- Description
- Start mode: Automatic, Manual (Recommended), or Disabled

---

### `services update`

Update an existing service's executable and assemblies.

```bash
./engine services update -i <service-id> -s <source-directory>
```

**Options:**
- `-i, --id <id>` - Service ID from the database (use `list` to find)
- `-s, --sourcedirectory <path>` - Source directory containing updated files

**Description:** Updates the service files from the source directory. Service must be on the current machine.

---

### `services remove`

Remove a Windows service.

```bash
./engine services remove -i <service-id>
```

**Options:**
- `-i, --id <id>` - Service ID from the database (use `list` to find)

**Description:** Stops and removes the Windows service and deletes the service directory.

**⚠️ Warning:** This is a destructive operation. The service will be permanently removed.

---

## Template Commands

Commands for creating new Ternary Engine projects and components from templates.

**Note:** These commands require the `_project` flag to be enabled.

### `templates assist`

Interactive template wizard.

```bash
./engine _project templates assist
```

**Description:** Launches an interactive menu to select from: List, Install, Create, or Add template operations.

---

### `templates list`

List all Ternary templates and their installation status.

```bash
./engine _project templates list
```

**Description:** Displays available Ternary templates:
- `ternary-dbcontext` - DbContext template (Item)
- `ternary-entity` - Model Entity template (Item)
- `ternary-runner` - Work Runner template (Item)
- `ternary-service` - Service template (Item)
- `ternary-worker` - Hosted Worker Service template (Item)
- `ternary-project` - Worker Service Project template (Project)

Shows whether each template is installed in `dotnet new`.

---

### `templates install`

Install all Ternary templates from the content folder.

```bash
./engine _project templates install
```

**Description:** Installs Template Authoring package (if needed) and all Ternary templates into `dotnet new` for use in scaffolding.

---

### `templates create`

Scaffold a new Ternary template into the appropriate project folder.

```bash
./engine _project templates create -p <prefix> -t <template> [options]
```

**Options:**
- `-p, --prefix <name>` - PascalCase prefix replacing 'MyExample' in template (e.g., 'Intake')
- `-t, --template <type>` - Template type: `dbcontext`, `worker`, `entity`, `service`, `runner`, or `project`
- `-s, --solution <path>` - Path to .sln file (for `project` template only, auto-discovered if omitted)

**Template Types & Output Locations:**

| Template | Output Directory | Generated Name Pattern |
|----------|------------------|------------------------|
| `dbcontext` | `.\Data` | `Ternary.Engine.{Prefix}DbContext` |
| `entity` | `.\Models` | `Ternary.Engine.{Prefix}Entity` |
| `runner` | `.\Runners` | `Ternary.Engine.{Prefix}Runner` |
| `service` | `.\Services` | `Ternary.Engine.{Prefix}Service` |
| `worker` | `.\Workers` | `Ternary.Engine.{Prefix}Worker` |
| `project` | `..\` | `Ternary.Engine.{Prefix}WorkerService` |

**Examples:**

```bash
# Create a DbContext
./engine _project templates create -p Intake -t dbcontext

# Create a Worker Service project
./engine _project templates create -p Intake -t project -s ./Ternary.Engine.sln

# Create an Entity
./engine _project templates create -p Customer -t entity
```

**Interactive Mode (via assist):**
- Prompts for prefix
- Shows menu to select template type
- For project template, prompts for solution file path

---

### `templates add`

Add an existing Worker Service project to the solution.

```bash
./engine _project templates add -p <project-path> [options]
```

**Options:**
- `-p, --project <path>` - Path to the project directory or .csproj file
- `-s, --solution <path>` - Path to the .sln file (auto-discovered if omitted)

**Description:** Adds an existing Worker Service project to the specified solution file.

---

## Service Mode

Run the application as a hosted service.

```bash
./engine run-service
```

**Description:** Runs the Ternary.Engine application in hosted service mode instead of CLI mode. This mode is used when the application is deployed as a Windows service or background worker.

---

## Examples

### Complete Workflow: Database Setup

```bash
# 1. List available contexts
./engine database list

# 2. Test connectivity
./engine database connect

# 3. Create database and apply migrations
./engine database create
```

### Complete Workflow: Creating a New Feature

```bash
# 1. Install templates (first time only)
./engine _project templates install

# 2. Create an Entity
./engine _project templates create -p Customer -t entity

# 3. Create a DbContext
./engine _project templates create -p Customer -t dbcontext

# 4. Create a Service
./engine _project templates create -p Customer -t service

# 5. Create a Worker
./engine _project templates create -p Customer -t worker

# 6. Add migration
./engine _project migrations add -c CustomerDbContext

# 7. Apply migration
./engine database update
```

### Complete Workflow: Managing Windows Services

```bash
# 1. List existing services
./engine services list

# 2. Create a new service instance
./engine services create -i ./bin/Release/net8.0/publish -o C:\MigrationServices

# 3. Update service later
./engine services update -i 1 -s ./bin/Release/net8.0/publish

# 4. Remove service when done
./engine services remove -i 1
```

---

## Troubleshooting

### "Could not retrieve the context"
- Ensure the context name is spelled correctly (case-insensitive)
- Run `database list` or `contexts list` to see available contexts
- Check that the context is properly registered in the application configuration

### "Could not find content directory"
- Ensure you're running from the correct directory
- The content directory should be in the project root or parent directories
- Check that templates are properly installed using `templates list`

### "Could not connect to the database"
- Verify connection string in configuration
- Ensure database server is running and accessible
- Check network connectivity and firewall rules
- Use `database connect` to test connectivity

### Service Creation Fails
- Ensure you have administrator privileges
- Check that the service name is unique
- Verify the source directory contains a valid executable
- Ensure the destination directory is accessible

---

## Additional Resources

For more information about the Ternary.Engine framework, see:
- [usage.md](usage.md) - Usage documentation
- [AddToProject.md](AddToProject.md) - Project integration guide
- [Ternary.Engine/readme.md](Ternary.Engine/readme.md) - Engine-specific documentation

---

## Notes

### Project Flag
Commands under `migrations` and `templates` require the `_project` flag:

```bash
./engine _project migrations <subcommand>
./engine _project templates <subcommand>
```

### Case Sensitivity
All command names, subcommands, and options are case-insensitive.

### Shell Completion
The CLI supports shell completion. Enable it using your shell's completion mechanism.

### Database Context Discovery
The application automatically discovers all DbContext types in the loaded assemblies. Use `database list` or `contexts list` to see available contexts.

### Migration Assembly
The migration assembly namespace is configured via `DatabaseSettings.MigrationAssembly` in the application configuration (defaults to `Ternary.Engine`).

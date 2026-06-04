# Usage
For local development iteration:
```shell
dotnet new uninstall Ternary.Engine.Templates
dotnet new install ./Ternary.Engine.Templates/
```

Scaffold a new service directly via dotnet:
```shell
dotnet new ternary-workservice --name Export --output ../Ternary.Engine.Export
```

Or via the CLI:
```shell
engine projects create --name Export
engine projects create --name Report --type Custom --output ../Ternary.Engine.Report --solution ./Ternary.Engine.sln
```

Pack for distribution:
```shell
dotnet pack Ternary.Engine.Templates/Ternary.Engine.Templates.csproj -o ./nupkg
```
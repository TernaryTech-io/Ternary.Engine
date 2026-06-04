Adding a Project to a .NET Solution via CLI
Yes — the dotnet sln command in the .NET CLI can add a project to an existing solution file.
Basic syntax
dotnet sln [<SOLUTION_FILE>] add <PROJECT_PATH>
SOLUTION_FILE: The .sln or .slnx file to modify. If omitted, the CLI searches the current directory for one and uses it Microsoft Learn.
PROJECT_PATH: The path to the .csproj file you want to add (relative or absolute).
Example:
dotnet sln add src/MyProject/MyProject.csproj
This adds src/MyProject/MyProject.csproj to the solution in the current directory Microsoft Learn+1.
Adding multiple projects
You can add more than one project at a time:
dotnet sln add src/ProjectA/ProjectA.csproj src/ProjectB/ProjectB.csproj
Adding all projects recursively
If you want to add all .csproj files in a directory tree, you can use a shell loop:
for file in **/*.csproj; do
 dotnet sln add "$file"
done
This works in PowerShell, Bash, or similar shells Stack Overflow.
Note: Direct wildcards like dotnet sln add **/*.csproj often fail with “Could not find project” errors because the CLI doesn’t expand them automatically Codegenes. Using a loop or ls/find in the shell is the recommended workaround.
Adding under a solution folder
If you want the project to appear in a specific folder in the IDE’s Solution Explorer, you can:
Use dotnet sln add as above.
Manually edit the .sln file to add a Project("{66A26720-8FB5-11D2-AA7E-00C04F688DDE}") entry for the folder, then link the project to it Bacancy.
Alternatively, open the solution in Visual Studio and use its UI to move the project into a folder.
Related commands
dotnet sln list – list all projects in the solution.
dotnet sln remove <PROJECT_PATH> – remove a project from the solution.
dotnet new sln – create a new solution file Microsoft Learn.
In summary: Use dotnet sln add <PROJECT_PATH> to include a project into a solution via the CLI, and use shell loops for bulk adds. For folder organization, you’ll need to edit the .sln file or use the IDE’s interface.
@ECHO off
set "filename=%~dp0\bin\Debug\net8.0\Ternary.Engine.exe"
set "executable=Ternary.Engine.exe"

IF /I "%~1"=="build" (
    goto build
)

if not defined 1 (
    if exist "%executable%" (
        goto command
    )
    if exist "%filename%" (
        goto project
    )
)

echo Something went wrong...
pause

:exit
EXIT /B

:build
dotnet build

goto exit

:command
:: Used for when the tool is installed in PATH and may be used for Services, or Projects
"%executable%" %*
goto exit

:project
:: Gives access to migration commands when run in the main folder.
"%filename%" _project %*
goto exit

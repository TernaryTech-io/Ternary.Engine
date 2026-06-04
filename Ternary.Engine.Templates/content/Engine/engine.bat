@ECHO off
set "filename=%~dp0bin\Debug\net8.0\EngineName.exe"
set "executable=EngineName.exe"

IF /I "%~1"=="build" (
    goto build
)

if "%~1"=="" (
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

echo whoops

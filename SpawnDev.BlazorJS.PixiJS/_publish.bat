
rmdir /Q /S "%~dp0bin\Publish\web"
dotnet publish --nologo--configuration Release --output "%~dp0bin\Publish\web"
pause

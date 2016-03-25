set net40_msbuild=\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set nuget_package_manager=..\.nuget\nuget.exe

set project_name=DouglasCrockford.JsMin
set project_source_dir=..\src\%project_name%

rmdir lib /Q/S

%net40_msbuild% %project_source_dir%\%project_name%.Net40.csproj /p:Configuration=Release
xcopy %project_source_dir%\bin\Release\%project_name%.dll lib\net40-client\
copy ..\LICENSE license.txt /Y

%nuget_package_manager% pack %project_name%.nuspec
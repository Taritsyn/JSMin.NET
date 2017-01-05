set net40_msbuild="\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
set nuget_package_manager=..\.nuget\nuget.exe
set dotnet_cli="%ProgramFiles%\dotnet\dotnet.exe"

set project_name=DouglasCrockford.JsMin
set net4_project_source_dir=..\src\%project_name%.Net4
set net4_project_bin_dir=%net4_project_source_dir%\bin\Release
set dotnet_project_source_dir=..\src\%project_name%
set dotnet_project_bin_dir=%dotnet_project_source_dir%\bin\Release

rmdir lib /Q/S

%net40_msbuild% "%net4_project_source_dir%\%project_name%.Net40.csproj" /p:Configuration=Release
xcopy %net4_project_bin_dir%\%project_name%.dll lib\net40-client\

%dotnet_cli% build "%dotnet_project_source_dir%" --framework netstandard1.1 --configuration Release --no-dependencies --no-incremental
xcopy "%dotnet_project_bin_dir%\netstandard1.1\%project_name%.dll" lib\netstandard1.1\ /E
xcopy "%dotnet_project_bin_dir%\netstandard1.1\%project_name%.xml" lib\netstandard1.1\ /E

copy ..\LICENSE license.txt /Y

%nuget_package_manager% pack %project_name%.nuspec
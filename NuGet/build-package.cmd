set net40_msbuild=\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set nuget_package_manager=..\.nuget\nuget.exe

set dnx_runtime_dir=%USERPROFILE%\.dnx\runtimes\dnx-clr-win-x86.1.0.0-rc1-final\bin
set dnx_runtime=%dnx_runtime_dir%\dnx.exe
set dnx_package_manager=%dnx_runtime_dir%\lib\Microsoft.Dnx.Tooling\Microsoft.Dnx.Tooling.dll

set project_name=DouglasCrockford.JsMin
set project_source_dir=..\src\%project_name%
set project_artifacts_dir=..\artifacts\bin\%project_name%

rmdir lib /Q/S

%net40_msbuild% %project_source_dir%\%project_name%.Net40.csproj /p:Configuration=Release
xcopy %project_source_dir%\bin\Release\%project_name%.dll lib\net40-client\

%dnx_runtime% --appbase %project_source_dir% %dnx_package_manager% build %project_source_dir% --framework net451 --configuration Release --out %project_artifacts_dir%
xcopy %project_artifacts_dir%\Release\net451\%project_name%.dll lib\net451\ /E
xcopy %project_artifacts_dir%\Release\net451\%project_name%.xml lib\net451\ /E

%dnx_runtime% --appbase %project_source_dir% %dnx_package_manager% build %project_source_dir% --framework dotnet5.4 --configuration Release --out %project_artifacts_dir%
xcopy %project_artifacts_dir%\Release\dotnet5.4\%project_name%.dll lib\dotnet5.4\ /E
xcopy %project_artifacts_dir%\Release\dotnet5.4\%project_name%.xml lib\dotnet5.4\ /E

copy ..\LICENSE license.txt /Y

%nuget_package_manager% pack %project_name%.nuspec
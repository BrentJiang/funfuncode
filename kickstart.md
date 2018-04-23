
# Create Project
- create project
dotnet new mvc --auth Individual

- routes
  /code/my/1
  
- db
There are many third party tools you can download to manage and view a SQLite database. The image below is from [DB Browser for SQLite](http://sqlitebrowser.org/). If you have a favorite SQLite tool, leave a comment on what you like about it.
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.1

Add-Migration -context MvcQrCodeContext Initial
update-database -context MvcQrCodeContext


# Publish & Deploy

# Publish on Linux

```shell
[root@izj6c4rpq4cctu9w4gz12iz funfuncode]# dotnet publish --help
Usage: dotnet publish [options]

Options:
  -h, --help                            Show help information.
  -o, --output <OUTPUT_DIR>             Output directory in which to place the published artifacts.
  -f, --framework <FRAMEWORK>           Target framework to publish for. The target framework has to be specified in the project file.
  -r, --runtime <RUNTIME_IDENTIFIER>    Publish the project for a given runtime. This is used when creating self-contained deployment. Default is to publish a framework-dependent app.
  -c, --configuration <CONFIGURATION>   Configuration to use for building the project.  Default for most projects is  "Debug".
  --version-suffix <VERSION_SUFFIX>     Defines the value for the $(VersionSuffix) property in the project.
  --manifest <manifest.xml>             The path to a target manifest file that contains the list of packages to be excluded from the publish step.
  --self-contained                      Publish the .NET Core runtime with your application so the runtime doesn't need to be installed on the target machine. Defaults to 'true' if a runtime identifier is specified.
  --no-restore                          Does not do an implicit restore when executing the command.
  -v, --verbosity                       Set the verbosity level of the command. Allowed values are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].
  --no-dependencies                     Set this flag to ignore project to project references and only restore the root project.
  --force                               Set this flag to force all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting project.assets.json.
```

publish for centos7, firstly add `centos.7-x64` in csproj file:

```xml
  <PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <UserSecretsId>aspnet-QRCodeMain-E6ED65A7-38D0-4C02-A1BF-289234844005</UserSecretsId>
	<RuntimeIdentifiers>win10-x64;osx.10.11-x64;centos.7-x64</RuntimeIdentifiers>
  </PropertyGroup>
```

and then publish:

`dotnet publish dotnetcore/QRCodeMain -o /home/PublishOutput/  -r centos.7-x64 -c Release`
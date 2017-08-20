using System.Text.RegularExpressions;
using System.Xml.Linq;

var target = Argument("Target", "Default");
var configuration =
    HasArgument("Configuration") ? Argument<string>("Configuration") :
    EnvironmentVariable("Configuration") != null ? EnvironmentVariable("Configuration") :
    "Release";
var preReleaseSuffix =
    HasArgument("PreReleaseSuffix") ? Argument<string>("PreReleaseSuffix") :
    (AppVeyor.IsRunningOnAppVeyor && AppVeyor.Environment.Repository.Tag.IsTag) ? null :
    EnvironmentVariable("PreReleaseSuffix") != null ? EnvironmentVariable("PreReleaseSuffix") :
    "beta";
var buildNumber =
    HasArgument("BuildNumber") ? Argument<int>("BuildNumber") :
    AppVeyor.IsRunningOnAppVeyor ? AppVeyor.Environment.Build.Number :
    TravisCI.IsRunningOnTravisCI ? TravisCI.Environment.Build.BuildNumber :
    EnvironmentVariable("BuildNumber") != null ? int.Parse(EnvironmentVariable("BuildNumber")) :
    0;

var artifactsDirectory = Directory("./Artifacts");
string versionSuffix = null;
if (!string.IsNullOrEmpty(preReleaseSuffix))
{
    versionSuffix = preReleaseSuffix + "-" + buildNumber.ToString("D4");
}

Task("Clean")
    .Does(() =>
    {
        CleanDirectory(artifactsDirectory);
        DeleteDirectories(GetDirectories("**/bin"), true);
        DeleteDirectories(GetDirectories("**/obj"), true);
    });

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        DotNetCoreRestore();
    });

 Task("BuildTool")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        var project = GetFiles("./**/Schema.NET.Tool.csproj").First();
        DotNetCoreBuild(
            project.GetDirectory().FullPath,
            new DotNetCoreBuildSettings()
            {
                Configuration = configuration
            });
    });

 Task("RunTool")
    .IsDependentOn("BuildTool")
    .Does(() =>
    {
        var project = GetFiles("./**/Schema.NET.Tool.csproj").First();
        DotNetCoreRun(project.ToString());

        Information("Started Listing Files");
        foreach (var file in GetFiles("./**/Schema.NET/**/*"))
        {
            Information(file.ToString());
        }
        Information("Finished Listing Files");
    });

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        DotNetCoreBuild(
            ".",
            new DotNetCoreBuildSettings()
            {
                Configuration = configuration,
                VersionSuffix = versionSuffix
            });
    });

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
    {
        foreach(var project in GetFiles("./Tests/**/*.csproj"))
        {
            var outputFilePath = MakeAbsolute(artifactsDirectory.Path)
                .CombineWithFilePath(project.GetFilenameWithoutExtension());
            DotNetCoreTool(
                project,
                "xunit",
                new ProcessArgumentBuilder()
                    .AppendSwitch("-configuration", configuration)
                    .AppendSwitchQuoted("-xml", outputFilePath.AppendExtension(".xml").ToString())
                    .AppendSwitchQuoted("-html", outputFilePath.AppendExtension(".html").ToString()));
        }
    });

Task("Pack")
    .IsDependentOn("Test")
    .Does(() =>
    {
        var project = GetFiles("./**/Schema.NET.csproj").First();
        DotNetCorePack(
            project.GetDirectory().FullPath,
            new DotNetCorePackSettings()
            {
                Configuration = configuration,
                OutputDirectory = artifactsDirectory,
                VersionSuffix = versionSuffix
            });
    });

Task("Default")
    .IsDependentOn("Pack");

RunTarget(target);
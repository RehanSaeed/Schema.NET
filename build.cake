var target = Argument("Target", "Default");
var configuration =
    HasArgument("Configuration") ? Argument<string>("Configuration") :
    EnvironmentVariable("Configuration") != null ? EnvironmentVariable("Configuration") :
    "Release";
var preReleaseSuffix =
    HasArgument("PreReleaseSuffix") ? Argument<string>("PreReleaseSuffix") :
    (TFBuild.IsRunningOnAzurePipelinesHosted && TFBuild.Environment.Repository.SourceBranch.StartsWith("refs/tags/")) ? null :
    (AppVeyor.IsRunningOnAppVeyor && AppVeyor.Environment.Repository.Tag.IsTag) ? null :
    EnvironmentVariable("PreReleaseSuffix") != null ? EnvironmentVariable("PreReleaseSuffix") :
    "beta";
var buildNumber =
    HasArgument("BuildNumber") ? Argument<int>("BuildNumber") :
    TFBuild.IsRunningOnAzurePipelinesHosted ? TFBuild.Environment.Build.Id :
    AppVeyor.IsRunningOnAppVeyor ? AppVeyor.Environment.Build.Number :
    EnvironmentVariable("BuildNumber") != null ? int.Parse(EnvironmentVariable("BuildNumber")) :
    0;
var azureArtefactsOrganization =
    HasArgument("AzureArtefactsOrganization") ? Argument<string>("AzureArtefactsOrganization") :
    EnvironmentVariable("AzureArtefactsOrganization") != null ? EnvironmentVariable("AzureArtefactsOrganization") :
    null;
var gitHubUserName =
    HasArgument("GitHubUserName") ? Argument<string>("GitHubUserName") :
    EnvironmentVariable("GitHubUserName") != null ? EnvironmentVariable("GitHubUserName") :
    null;
var gitHubPassword =
    HasArgument("GitHubPassword") ? Argument<string>("GitHubPassword") :
    EnvironmentVariable("GitHubPassword") != null ? EnvironmentVariable("GitHubPassword") :
    null;
var nuGetApiKey =
    HasArgument("NuGetApiKey") ? Argument<string>("NuGetApiKey") :
    EnvironmentVariable("NuGetApiKey") != null ? EnvironmentVariable("NuGetApiKey") :
    null;

var artefactsDirectory = Directory("./Artefacts");
var versionSuffix = string.IsNullOrEmpty(preReleaseSuffix) ? null : preReleaseSuffix + "-" + buildNumber.ToString("D4");

Task("Clean")
    .Does(() =>
    {
        CleanDirectory(artefactsDirectory);
        DeleteDirectories(GetDirectories("**/bin"), new DeleteDirectorySettings() { Force = true, Recursive = true });
        DeleteDirectories(GetDirectories("**/obj"), new DeleteDirectorySettings() { Force = true, Recursive = true });
    });

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        DotNetCoreRestore();
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
                NoRestore = true,
                VersionSuffix = versionSuffix
            });
    });

 Task("RunTool")
    .IsDependentOn("Build")
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

Task("Test")
    .DoesForEach(GetFiles("./Tests/**/*.csproj"), project =>
    {
        DotNetCoreTest(
            project.ToString(),
            new DotNetCoreTestSettings()
            {
                Configuration = configuration,
                Logger = $"trx;LogFileName={project.GetFilenameWithoutExtension()}.trx",
                NoBuild = true,
                NoRestore = true,
                ResultsDirectory = artefactsDirectory,
                ArgumentCustomization = x => x.Append($"--logger html;LogFileName={project.GetFilenameWithoutExtension()}.html")
            });
    });

Task("Pack")
    .Does(() =>
    {
        DotNetCorePack(
            ".",
            new DotNetCorePackSettings()
            {
                Configuration = configuration,
                IncludeSymbols = true,
                MSBuildSettings = new DotNetCoreMSBuildSettings().WithProperty("SymbolPackageFormat", "snupkg"),
                NoBuild = true,
                NoRestore = true,
                OutputDirectory = artefactsDirectory,
                VersionSuffix = versionSuffix,
            });
    });

Task("PushAzureArtefacts")
    .DoesForEach(GetFiles(artefactsDirectory + File("./*.nupkg")), nugetPackage =>
    {
        NuGetPush(
            nugetPackage,
            new NuGetPushSettings()
            {
                ApiKey = "AzureArtefacts",
                SkipDuplicate = true,
                Source = $"https://pkgs.dev.azure.com/{azureArtefactsOrganization}/_packaging/{azureArtefactsOrganization}/nuget/v3/index.json",
            });
    });

Task("AuthenticateGitHub")
    .Does(() =>
    {
        NuGetAddSource(
            "GitHub",
            "https://nuget.pkg.github.com/RehanSaeed/index.json",
            new NuGetSourcesSettings()
            {
                UserName = gitHubUserName,
                Password = gitHubPassword,
            });
    });

Task("PushGitHub")
    .IsDependentOn("AuthenticateGitHub")
    .DoesForEach(GetFiles(artefactsDirectory + File("./*.nupkg")), nugetPackage =>
    {
        NuGetPush(
            nugetPackage,
            new NuGetPushSettings()
            {
                SkipDuplicate = true,
                Source = "GitHub",
            });
    });

Task("PushNuGet")
    .DoesForEach(GetFiles(artefactsDirectory + File("./*.nupkg")), nugetPackage =>
    {
        NuGetPush(
            nugetPackage,
            new NuGetPushSettings()
            {
                ApiKey = nuGetApiKey,
                SkipDuplicate = true,
                Source = "https://api.nuget.org/v3/index.json",
            });
    });

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
    .IsDependentOn("Pack");

RunTarget(target);

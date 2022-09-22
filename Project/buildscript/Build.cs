using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    public static int Main () => Execute<Build>(x => x.RunUnitTests);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;

    Target Clean => _ => _
        .Before(RestorePackages)
        .Executes(() =>
        {
            GlobDirectories(Solution.Directory, "src/**/bin", "src/**/obj").ForEach(DeleteDirectory);
        });

    Target RestorePackages => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(a => a.SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(RestorePackages)
        .Executes(() =>
        {
            DotNetBuild(a => a.SetProjectFile(Solution).EnableNoRestore());
        });

    Target RunUnitTests => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            var testProjects = Solution.AllProjects
                .Where(a => a.Name.EndsWith("tests.unit", StringComparison.OrdinalIgnoreCase))
                .ToList();
            
            Logger.Info($"{testProjects.Count} unit test projects found");

            foreach (var testProject in testProjects)
            {
                DotNetTest(a => 
                    a.SetProjectFile(testProject)
                        .EnableNoBuild()
                        .EnableNoRestore());
            }
        });
}

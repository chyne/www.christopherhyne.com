#tool nuget:?package=Wyam&version=2.1.2
#addin nuget:?package=Cake.Wyam&version=2.1.2

var target = Argument("target", "Default");

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings {
            Recipe = "Blog",
            Theme = "CleanBlog"
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true
        });        
    });

Task("Default")
  .IsDependentOn("Preview");

RunTarget(target);
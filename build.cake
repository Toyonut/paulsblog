#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var buildDir = Directory("./output");

// Devine output Zip file
var outputZip = "paulsblog.zip";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task ("Clean")
    .Does(() =>
    {
        if (FileExists(outputZip)) {
            Information("Output zip found, deleting.");
            DeleteFile(outputZip);
        }

        if (DirectoryExists(buildDir)) {
            Information("Output directory found, deleting.");
            DeleteDirectory(buildDir, recursive:true);
        }
    });

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            UseLocalPackages = true
        });  
        
        Zip("./output", outputZip);   
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true,
            UseLocalPackages = true
        });        
    });

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Build");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

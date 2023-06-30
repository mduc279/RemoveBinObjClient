var sourceFolder = @"D:\AOD Projects\DSSClients";
var directory = Directory.GetDirectories(sourceFolder, "*", SearchOption.AllDirectories);
var binObjFolders = directory.Where(x => x.EndsWith("bin") || x.EndsWith("obj") || x.EndsWith(@"AOD.DSSClients.UWP\AppPackages"));
Console.WriteLine($"\nFound {binObjFolders.Count()} folders to remove in {sourceFolder}.\n");
foreach (var folder in binObjFolders)
{
    try
    {
        Directory.Delete(folder, true);
        Console.WriteLine($"Removed {folder}.");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}
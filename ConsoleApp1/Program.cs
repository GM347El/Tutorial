

//string dir = Directory.GetCurrentDirectory();
string newDir=Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Programming\Pages"));
string[] dirs = Directory.GetFiles(newDir,"*.razor", SearchOption.AllDirectories);
foreach (string directory in dirs)
{
    Console.WriteLine(directory.ToString());
}
//Console.WriteLine(dir);
Console.WriteLine(newDir);
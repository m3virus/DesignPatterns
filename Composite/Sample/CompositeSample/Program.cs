using CompositeSample.Models;

var root = new FolderItem("Root");
var file1 = new FileItem("File1.txt");
var file2 = new FileItem("File2.txt");

var subFolder = new FolderItem("SubFolder");
subFolder.Add(new FileItem("File3.txt"));

root.Add(file1);
root.Add(file2);
root.Add(subFolder);

root.Display();
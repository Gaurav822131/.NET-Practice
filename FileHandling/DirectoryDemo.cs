using System;
using System.IO;
namespace FileIODemo;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            System.Console.WriteLine("Folder already exist");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder created...");
        }
    }
    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo=new DriveInfo(driveName);
        System.Console.WriteLine($"drive Name{dInfo.Name}");
        System.Console.WriteLine($"drive FileSystem{dInfo.DriveFormat}");
        System.Console.WriteLine($"drive DriveType{dInfo.DriveType}");
        System.Console.WriteLine($"Size of the drive{dInfo.TotalSize}");
        System.Console.WriteLine($"Drive FreeSpace{dInfo.TotalFreeSpace}");
    }

    public void PathDemoFunc()
    {
        string s=@"CC:/\temp\MyData.text\machine.config\Alok\Dummy.Data\ABC.cs";
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
}

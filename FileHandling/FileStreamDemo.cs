using System;
using System.IO;
namespace FileIODemo;

public class FileStreamDemo
{   
    FileStream fs=null;
    StreamWriter sw=null;
    public void CreateFunc(string fileName)
    {   StreamWriter sw=null;
        try{
        fs=new FileStream(fileName,FileMode.Create,FileAccess.Write);
        sw=new StreamWriter(fs);
        sw.WriteLine("This is just a simple file for file IO demo");
        }
        catch(FileNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (FileLoadException e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally{
        sw.Close();
        fs.Close();
        }
    }
    public void readFile(string fileName)
    {
        fs =new FileStream(fileName,FileMode.Open,FileAccess.Read);
        StreamReader sr=new StreamReader(fs);
        
    }
}

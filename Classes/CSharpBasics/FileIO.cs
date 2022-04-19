using System.IO;

public class FileIO
{
    public void ReadFile()
    {
        var fileContent = File.ReadAllText("path to file");
        
        FileInfo fi = new("");
    }

    public void ReadFolder()
    {
        var fileContent = Directory.CreateDirectory("path to file");
        
        DirectoryInfo di = new("");
    }
}
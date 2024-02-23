namespace DependencyInversionPrinciple;

using System.IO;

class FileCreator
{
    private FileStream fileStream;
    private string filePath;

    public FileCreator(string filePath)
    {
        this.filePath = filePath;
        fileStream = null;
    }

    public void CreateFile(string fileName)
    {
        try
        {
            fileStream = new FileStream(filePath + fileName, FileMode.Create);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error while creating file: {ex.Message}");
        }
        finally
        {
            fileStream.Dispose();
        }
        
    }

    public void WriteToFile(string fileName, string text)
    {
        try
        {
            using(StreamWriter writer = new StreamWriter(filePath + fileName))
            {
                writer.WriteLine(text);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error while writing to file: {ex.Message}");
        }
    }
}

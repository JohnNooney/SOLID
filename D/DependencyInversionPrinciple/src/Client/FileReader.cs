namespace DependencyInversionPrinciple;

using System.IO;

// Reads file from a specified directory location
// and once read, copies files from source to destination
class FileReader
{
    private string sourcePath;
    private string destinationPath;

    public FileReader(string sourcePath, string destinationPath)
    {
        this.sourcePath = sourcePath;
        this.destinationPath = destinationPath;
    }

    public void ReadFile(string fileName)
    {
        readFromSource(fileName);
        copyToDestination(fileName);
    }

    private void readFromSource(string fileName)
    {
        Console.WriteLine($"Reading file: {fileName}");

        try
        {
            using(StreamReader reader = new StreamReader(sourcePath + fileName))
            {
                string line = reader.ReadLine();

                while(line != null) 
                {
                    Console.WriteLine(line);

                    line = reader.ReadLine();
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error while reading {fileName}: {ex.Message}");
        }
    }

    private void copyToDestination(string fileName)
    {
        try
        {
            File.Copy(sourcePath + fileName, destinationPath + fileName, true);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error while copying {fileName}: {ex.Message}");
        }
    }
}

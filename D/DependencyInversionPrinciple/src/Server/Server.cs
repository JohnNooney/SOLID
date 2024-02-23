namespace DependencyInversionPrinciple;

class Server
{
    private const string FILE_PATH = "/src/Server/CreatedFiles/";
    private FileCreator fileCreator;
    private FileCreatedNotifier notifier;

    public Server()
    {
        string fileCreatorPath = System.IO.Directory.GetCurrentDirectory() + FILE_PATH;
        
        fileCreator = new FileCreator(fileCreatorPath);
        notifier = FileCreatedNotifier.GetFileCreatedNotifier();
    }

    public void CreateFileWithHeader(string fileName, string fileHeader)
    {
        Console.WriteLine($"Creating file: {fileName}");
        fileCreator.CreateFile(fileName);

        Console.WriteLine($"\nWriting header to file: {fileName}");
        fileCreator.WriteToFile(fileName, fileHeader);
    }

    public void NotifyFileCreated(string fileName)
    {
        Console.WriteLine($"Publishing notification for: {fileName} \n");

        notifier.NotifyFileCreated(fileName);
    }

    public void Shutdown()
    {
        Console.WriteLine($"Sutting down server.\n");
    }
}

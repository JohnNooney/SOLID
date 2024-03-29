namespace DependencyInversionPrinciple;

class Client
{
    private const string FILE_DESTINATION_PATH = "/src/Client/ReadFiles/";
    private const string FILE_SOURCE_PATH = "/src/Server/CreatedFiles/";
    private string clientIdentifier;
    private FileReader fileReader;
    private FileCreatedSubscriber subscriber;
    private FileCreatedNotifier notifier;

    public Client(string clientIdentifier)
    {
        this.clientIdentifier = clientIdentifier;

        string fileReaderDestinationPath = System.IO.Directory.GetCurrentDirectory() + FILE_DESTINATION_PATH;
        string fileReaderSourcePath =  System.IO.Directory.GetCurrentDirectory() + FILE_SOURCE_PATH;

        fileReader = new FileReader(fileReaderSourcePath, fileReaderDestinationPath);

        notifier = FileCreatedNotifier.GetFileCreatedNotifier();
    }

    public void SubscribeToFile(string fileName)
    {
        Console.WriteLine($"{clientIdentifier} subscribing to file: {fileName}");

        subscriber = new FileCreatedSubscriber(fileName);
        subscriber.SetCallback(FileCreatedCallback);

        notifier.Subscribe(subscriber);
    }

    public void Shutdown()
    {
        Console.WriteLine($"Shutting down {clientIdentifier}");

        notifier.Unsubscribe(subscriber);
    }

    public void FileCreatedCallback(string fileName)
    {
        Console.WriteLine($"{clientIdentifier} callback");

        fileReader.ReadFile(fileName);
    }
}
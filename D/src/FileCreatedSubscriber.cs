namespace DependencyInversionPrinciple;

class FileCreatedSubscriber : ISubscriber
{
    public delegate void FileCreatedCallback(string fileName); 
    private FileCreatedCallback callback;

    public FileCreatedSubscriber(string fileName)
    {
        subscribedFile = fileName;
    }

    public string subscribedFile{get; set;}

    public void Update(string fileName)
    {
        Console.WriteLine($"File created: {fileName}");

        callback(fileName);
    }

    public void SetCallback(FileCreatedCallback callback)
    {
        this.callback = callback;
    }
}

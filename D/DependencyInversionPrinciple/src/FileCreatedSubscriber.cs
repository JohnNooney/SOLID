namespace DependencyInversionPrinciple;

class FileCreatedSubscriber : ISubscriber
{
    public FileCreatedSubscriber(string fileName)
    {
        subscribedFile = fileName;
    }

    public string subscribedFile{get; set;}

    public void Update(string fileName)
    {
        Console.WriteLine($"File created: {fileName}");
    }
}

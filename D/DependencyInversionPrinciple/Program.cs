namespace DependencyInversionPrinciple;

class Program
{
    static void Main(string[] args)
    {
       Server server = new Server();
       
       publishFileToServerForSubscriber(server, "subscriber1");
       publishFileToServerForSubscriber(server, "subscriber2");

       server.Shutdown();
    }

    public static void publishFileToServerForSubscriber(Server server, string subscriber)
    {
        string subscriberFile = subscriber + ".txt";
        string subscriberFileHeader = "This file is for " + subscriber;

        server.CreateFileWithHeader(subscriberFile, subscriberFileHeader);
        server.NotifyFileCreated(subscriberFile);
    }
}

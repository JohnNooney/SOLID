namespace DependencyInversionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Server server = new Server();
       
        Client client1 = new Client("client1");
       
        clientSubscription(client1, "subscriber1");
       
        publishFileToServerForSubscriber(server, "subscriber1");
        publishFileToServerForSubscriber(server, "subscriber2");
       
        client1.Shutdown();
        server.Shutdown();
       
    }

    public static void publishFileToServerForSubscriber(Server server, string subscriber)
    {
        string subscriberFile = subscriber + ".txt";
        string subscriberFileHeader = "This file is for " + subscriber;

        server.CreateFileWithHeader(subscriberFile, subscriberFileHeader);
        server.NotifyFileCreated(subscriberFile);
    }

    public static void clientSubscription(Client client, string subscriber)
    {
        string subscriberFile = subscriber + ".txt";
        
        client.SubscribeToFile(subscriberFile);
    }
}

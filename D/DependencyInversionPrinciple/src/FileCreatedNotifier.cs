namespace DependencyInversionPrinciple;

class FileCreatedNotifier
{
    private List<ISubscriber> subscribers;
    private static FileCreatedNotifier singletonNotifier;

    private FileCreatedNotifier()
    {
        subscribers = new List<ISubscriber>();
    }

    public static FileCreatedNotifier GetFileCreatedNotifier()
    {
        if(singletonNotifier == null)
        {
            singletonNotifier = new FileCreatedNotifier();
        }

        return singletonNotifier;
    }

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void NotifyFileCreated(string fileName)
    {
        foreach(ISubscriber subscriber in subscribers)
        {
            if(subscriber.subscribedFile == fileName)
            {
                subscriber.Update(fileName);
            }
        }
    }
}

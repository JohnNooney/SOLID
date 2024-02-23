namespace DependencyInversionPrinciple;

class FileCreatedNotifier
{
    private List<ISubscriber> subscribers;

    public FileCreatedNotifier()
    {
        subscribers = new List<ISubscriber>();
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

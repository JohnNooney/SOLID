namespace DependencyInversionPrinciple;

interface ISubscriber
{
    string subscribedFile {get; set;}
    void Update(string filename);
}

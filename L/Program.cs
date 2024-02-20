namespace LiskovSubstitutionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        ShapeCreatorClient client = new ShapeCreatorClient();
        client.Main();
    }
}

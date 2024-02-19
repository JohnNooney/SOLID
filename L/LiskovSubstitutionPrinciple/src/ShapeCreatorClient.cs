namespace LiskovSubstitutionPrinciple;

class ShapeCreatorClient
{
    string enteredShape;
    int[] enteredDimensions = new int[2];
    int shapeArea;
    ShapeFactory factory;

    public void Main()
    {
        collectUserInput();
        createShapeFactory();

        shapeArea = factory.getShapeArea(enteredDimensions);
        
        Console.WriteLine($"Your {enteredShape} array has an area of: {shapeArea}");
    }

    public void collectUserInput()
    {
        Console.WriteLine("Enter a shape: ");
        string enteredShape = Console.ReadLine();

        Console.WriteLine("Enter your shape's dimensions.");
        Console.WriteLine("Dimension 1: ");
        enteredDimensions.Append(int.Parse(Console.ReadLine()));

        if(enteredShape == "rectangle")
        {
            Console.WriteLine("Dimension 2: ");
            enteredDimensions.Append(int.Parse(Console.ReadLine()));
        }
    }

    public void createShapeFactory()
    {
        switch (enteredShape)
        {
            case "rectangle":
                factory = new RectangleFactory();
                break;
            case "circle":
                factory = new CircleFactory();
                break;
            case "square":
                factory = new SquareFactory();
                break;
            default:
                Console.WriteLine("shape not found");
                break;
        }
    }
}

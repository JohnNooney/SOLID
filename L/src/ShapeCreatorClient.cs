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

        Console.WriteLine($"Your {enteredShape} has an area of: {shapeArea}");
    }

    public void collectUserInput()
    {
        Console.WriteLine("Enter a shape: ");
        enteredShape = Console.ReadLine();

        Console.WriteLine("Enter your shape's dimensions.");
        Console.WriteLine("Dimension 1: ");
        enteredDimensions[0] = (int.Parse(Console.ReadLine()));

        if(enteredShape == "rectangle")
        {
            Console.WriteLine("Dimension 2: ");
            enteredDimensions[1] = (int.Parse(Console.ReadLine()));
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
                throw new Exception("shape not found");
        }
    }
}

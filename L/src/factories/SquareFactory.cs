namespace LiskovSubstitutionPrinciple;

class SquareFactory : ShapeFactory
{
    public override Shape shapeFactoryMethod()
    {
        return new Square();
    }
}

namespace LiskovSubstitutionPrinciple;

class RectangleFactory : ShapeFactory
{
    public override Shape shapeFactoryMethod()
    {
        return new Rectangle();
    }
}

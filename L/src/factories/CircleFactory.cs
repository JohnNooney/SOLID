namespace LiskovSubstitutionPrinciple;

class CircleFactory : ShapeFactory
{
    public override Shape shapeFactoryMethod()
    {
        return new Circle();
    }
}

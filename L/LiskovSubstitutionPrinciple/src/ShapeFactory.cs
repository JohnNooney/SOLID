namespace LiskovSubstitutionPrinciple;

abstract class ShapeFactory
{
    public abstract Shape shapeFactoryMethod();

    public int getShapeArea(params int[] dimensions)
    {
        Shape shape = shapeFactoryMethod();
        
        shape.SetDimensions(dimensions);
        
        return shape.GetArea();
    }
}

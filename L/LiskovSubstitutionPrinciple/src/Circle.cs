namespace LiskovSubstitutionPrinciple;

class Circle : Shape
{
    public override int GetArea()
    {
        return (int) (dimension * Math.PI);
    }
}

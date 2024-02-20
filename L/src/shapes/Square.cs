namespace LiskovSubstitutionPrinciple;

class Square : Shape
{
    public override int GetArea()
    {
        return dimension * dimension;
    }
}

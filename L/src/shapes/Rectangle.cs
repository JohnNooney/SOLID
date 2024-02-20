namespace LiskovSubstitutionPrinciple;

class Rectangle : Shape
{
    protected int dimension2;

    public override void SetDimensions(params int[] dimensions)
    {
        if(dimensions[0] == null || dimensions[1] == null)
        {
            throw new Exception("both dimensions not supplied.");
        }

        dimension = dimensions[0];
        dimension2 = dimensions[1];
    }

    public override int GetArea()
    {
        return dimension * dimension2;
    }
}

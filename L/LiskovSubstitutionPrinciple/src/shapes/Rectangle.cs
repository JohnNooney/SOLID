namespace LiskovSubstitutionPrinciple;

class Rectangle : Shape
{
    protected int dimension2;

    public override void SetDimensions(params int[] dimensions)

        dimension = dimensions[0];
        dimension2 = dimensions[1];
    }

    public override int GetArea()
    {
        return dimension * dimension2;
    }
}

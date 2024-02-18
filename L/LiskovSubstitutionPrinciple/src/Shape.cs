namespace LiskovSubstitutionPrinciple;

abstract class Shape
{
    protected int dimension;

    public virtual void SetDimensions(params int[] dimension)
    {
        if(dimension[0] == null)
        {
            throw new Exception("dimension not supplied.");
        }

        this.dimension = dimension[0];
    }

    public abstract int GetArea();

}

namespace InterfaceSegregationPrinciple;

class Table : IFurniture, IMaterial
{
    public FurnitureDimensions dimensions {get; set;}
    public string color {get; set;}
    public string style {get; set;}
    public string condition {get; set;}
    public string material {get; set;}

    public void SetDimensions(double length, double width, double height)
    {
        dimensions = new FurnitureDimensions(length, width, height);
    }
}

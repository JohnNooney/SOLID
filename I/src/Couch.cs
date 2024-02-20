namespace InterfaceSegregationPrinciple;

class Couch : IFurniture, IFabric
{
    public FurnitureDimensions dimensions {get; set;}
    public string color {get; set;}
    public string style {get; set;}
    public string condition {get; set;}
    public string fabric {get; set;}

    public void SetDimensions(double length, double width, double height)
    {
        dimensions = new FurnitureDimensions(length, width, height);
    }
}


namespace InterfaceSegregationPrinciple;

interface IFurniture
{
    FurnitureDimensions dimensions {get; set;}
    string color {get; set;}
    string style {get; set;}
    string condition {get; set;}

    void SetDimensions(double length, double width, double height);
}

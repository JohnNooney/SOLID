using System.ComponentModel.DataAnnotations;

namespace InterfaceSegregationPrinciple;

class FurnitureDimensions
{
    private double _length;
    private double _width;
    private double _height;

    public FurnitureDimensions(double length, double width, double height)
    {
        this._length = length;
        this._width = width;
        this._height = height;
    }

    public double width {get { return _width;}}
    public double length {get { return _length;}}
    public double height {get { return _height;}}

    public double GetArea()
    {
        return _length * _width;
    }

    public double GetVolume()
    {
        return _length * _width * _height;
    }

}

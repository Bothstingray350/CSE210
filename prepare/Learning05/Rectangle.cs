public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _height = height;
        _width = width;
    }
    public override double GetArea()
    {
        return _width * _height;
    }
}
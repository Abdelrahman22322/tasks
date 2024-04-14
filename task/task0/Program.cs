namespace task0;

interface IShapeCalculator
{
    double CalculateArea(double length, double width);
    double CalculatePerimeter(double length, double width);
}

class RectangleCalculator : IShapeCalculator
{
    public double CalculateArea(double length, double width)
    {
        return length * width;
    }

    public double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
}

class Rectangle(IShapeCalculator calculator)
{
    public double Length { get; init; }
    public double Width { get; init; }

    public double CalculateArea()
    {
        return calculator.CalculateArea(Length, Width);
    }

    public double CalculatePerimeter()
    {
        return calculator.CalculatePerimeter(Length, Width);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShapeCalculator calculator = new RectangleCalculator();

        Rectangle rectangle1 = new Rectangle(calculator) { Length = 5, Width = 4 };
        Rectangle rectangle2 = new Rectangle(calculator) { Length = 7, Width = 3.5 };

        Console.WriteLine("Rectangle 1:");
        Console.WriteLine("Area: " + rectangle1.CalculateArea());
        Console.WriteLine("Perimeter: " + rectangle1.CalculatePerimeter());

        Console.WriteLine("\nRectangle 2:");
        Console.WriteLine("Area: " + rectangle2.CalculateArea());
        Console.WriteLine("Perimeter: " + rectangle2.CalculatePerimeter());
    }
}
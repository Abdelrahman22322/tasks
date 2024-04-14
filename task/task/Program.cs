
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 abstract class  Shape
{
    public abstract double CalculateArea();
}

 class Rectangle : Shape
 {
     public override double CalculateArea()
     {
         throw new NotImplementedException();
     }
 }

 class Circle : Shape
 {
     public override double CalculateArea()
     {
         throw new NotImplementedException();
     }
 }
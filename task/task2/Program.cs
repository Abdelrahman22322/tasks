using System;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Directly use lambda expressions within Console.WriteLine statements
        Console.WriteLine("Addition: " + ((Func<int, int, int>)((a, b) => a + b))(5, 3)); // Output: 8

        Console.WriteLine("Subtraction: " + ((Func<int, int, int>)((a, b) => a - b))(5, 3)); // Output: 2

        Console.WriteLine("Multiplication: " + ((Func<int, int, int>)((a, b) => a * b))(5, 3)); // Output: 15

        Console.WriteLine("Division: " + ((Func<int, int, int>)((a, b) => {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("Cannot divide by zero.");
        }))(10, 5)); // Output: 2
    }
}
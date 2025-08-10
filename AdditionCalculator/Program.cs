using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Addition Calculator ===");
        Console.WriteLine("---------------------------"); // Change 1: Added separator

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;

        Console.WriteLine($"Result: {num1} + {num2} = {result}");

        Console.WriteLine("\nThank you for using the calculator!"); // Change 2: Added thank you message

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

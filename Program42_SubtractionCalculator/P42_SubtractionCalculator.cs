using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 - num2;

        Console.WriteLine($"The difference between {num1} and {num2} is: {result}");
    }
}

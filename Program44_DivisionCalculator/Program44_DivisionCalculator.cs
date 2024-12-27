using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"The division of {num1} by {num2} is: {result}");
        }
    }
}

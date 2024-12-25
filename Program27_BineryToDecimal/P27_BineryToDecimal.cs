using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد باینری را وارد کنید: ");
        string binary = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(binary, 2);
        Console.WriteLine($"عدد دسیمال: {decimalNumber}");
    }
}

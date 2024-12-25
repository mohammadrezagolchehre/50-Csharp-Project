using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد دسیمال را وارد کنید: ");
        int number = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        Console.WriteLine($"عدد باینری: {binary}");
    }
}

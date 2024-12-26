using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("GCD and LCM Calculator");

        // دریافت دو عدد از کاربر
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // محاسبه GCD و LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        // نمایش نتایج
        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }

    // تابع برای محاسبه GCD با استفاده از الگوریتم اقلیدس
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // تابع برای محاسبه LCM
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}

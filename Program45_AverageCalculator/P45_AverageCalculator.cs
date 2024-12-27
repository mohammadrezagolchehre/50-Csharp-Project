using System;

class Program45_AverageCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Average Calculator");
        Console.WriteLine("-------------------");

        // گرفتن تعداد اعداد از کاربر
        Console.Write("Enter the number of values: ");
        int count = int.Parse(Console.ReadLine());

        // بررسی اگر تعداد ورودی کمتر از 1 باشد
        if (count < 1)
        {
            Console.WriteLine("You must enter at least one number.");
            return;
        }

        double sum = 0;

        // گرفتن اعداد و محاسبه مجموع
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Enter number {i}: ");
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        // محاسبه و نمایش میانگین
        double average = sum / count;
        Console.WriteLine($"\nThe average of the entered numbers is: {average:F2}");
    }
}

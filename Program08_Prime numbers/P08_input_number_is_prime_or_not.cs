using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        // چک کردن عدد اول بودن
        if (IsPrime(number))
        {
            Console.WriteLine($"{number} یک عدد اول است.");
        }
        else
        {
            Console.WriteLine($"{number} یک عدد اول نیست.");
        }
    }

    // تابع چک کردن عدد اول بودن
    static bool IsPrime(int num)
    {
        if (num <= 1) return false; // اعداد کمتر از 2 اول نیستند
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false; // اگر عدد بر i تقسیم شد، اول نیست
        }
        return true; // اگر به هیچ عددی تقسیم نشد، عدد اول است
    }
}

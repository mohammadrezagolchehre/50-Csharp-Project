using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفاً یک عدد غیر منفی وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        // بررسی عدد منفی
        if (number < 0)
        {
            Console.WriteLine("لطفاً یک عدد غیر منفی وارد کنید.");
        }
        else
        {
            // محاسبه فاکتوریل
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // نمایش نتیجه
            Console.WriteLine($"فاکتوریل {number} برابر با {factorial} است.");
        }
    }
}

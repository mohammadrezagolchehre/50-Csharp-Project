using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        // محاسبه مجموع ارقام عدد
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;  // گرفتن باقی‌مانده تقسیم بر 10 
            number /= 10;         // حذف رقم آخر
        }

        // نمایش نتیجه
        Console.WriteLine($"مجموع ارقام عدد برابر با {sum} است.");
    }
}

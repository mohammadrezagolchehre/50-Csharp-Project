using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("لطفاً یک رشته وارد کنید:");
        //دریافت ورودی از کاربر
        string input = Console.ReadLine();

        // قرار دادن ورودی در تابع معکوس سازی
        string reversed = ReverseString(input);
        //نمایش خروجی
        Console.WriteLine($"رشته معکوس: {reversed}");
    }

    static string ReverseString(string str)
    {
        // تبدیل رشته به آرایه کاراکترها
        char[] charArray = str.ToCharArray();
        // معکوس کردن آرایه
        Array.Reverse(charArray);
        // تبدیل آرایه معکوس شده به رشته
        return new string(charArray); 
    }
}

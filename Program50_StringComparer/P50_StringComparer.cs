using System;

class Program
{
    static void Main()
    {
        // درخواست از کاربر برای وارد کردن دو رشته
        Console.Write("لطفاً رشته اول را وارد کنید: ");
        string str1 = Console.ReadLine();

        Console.Write("لطفاً رشته دوم را وارد کنید: ");
        string str2 = Console.ReadLine();

        // مقایسه دو رشته
        if (str1 == str2)
        {
            Console.WriteLine("رشته‌ها برابر هستند.");
        }
        else
        {
            Console.WriteLine("رشته‌ها برابر نیستند.");
            Console.WriteLine("تفاوت‌ها:");
            // نمایش تفاوت‌ها بین دو رشته
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (str1[i] != str2[i])
                {
                    Console.WriteLine($"در موقعیت {i+1}, کاراکترهای رشته‌ها متفاوت هستند: {str1[i]} != {str2[i]}");
                }
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // درخواست برای وارد کردن شماره ماه
        Console.Write("لطفاً شماره ماه (1 تا 12) را وارد کنید: ");
        int monthNumber = int.Parse(Console.ReadLine());

        // آرایه‌ای از نام ماه‌های شمسی
        string[] months = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", 
                            "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        // بررسی اینکه شماره ماه وارد شده معتبر است یا خیر
        if (monthNumber >= 1 && monthNumber <= 12)
        {
            // نمایش نام ماه شمسی
            Console.WriteLine("ماه مورد نظر: " + months[monthNumber - 1]);
        }
        else
        {
            // پیام خطا در صورت وارد کردن شماره نامعتبر
            Console.WriteLine("لطفاً شماره ماه صحیح (1 تا 12) وارد کنید.");
        }
    }
}

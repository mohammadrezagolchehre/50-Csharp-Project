using System;

class Program
{
    static void Main(string[] args)
    {
        //دریافت ورودی از کاربر
        Console.WriteLine("لطفاً سال تولد خود را وارد کنید:");
        string input = Console.ReadLine();

        // تبدیل ورودی به عدد با tryparse
        if (int.TryParse(input, out int birthYear))
        {
            //دریافت تاریخ سالی الان سیستم
            int currentYear = DateTime.Now.Year;
            //کم کردن سال تولد از تاریخ حال
            int age = currentYear - birthYear;
            //بررسی صحت داده ورودی
            if (age >= 0)
            {
                Console.WriteLine($"سن شما: {age} سال است.");
            }
            else
            {
                Console.WriteLine("شما هنوز به دنیا نیامده اید:)");
            }
        }
        else
        {
            Console.WriteLine("لطفاً یک عدد معتبر وارد کنید.");
        }
    }
}

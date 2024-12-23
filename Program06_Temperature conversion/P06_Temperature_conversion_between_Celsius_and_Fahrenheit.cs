using System;

class Program
{
    static void Main()
    {
        // انتخاب نوع تبدیل
        Console.WriteLine("لطفاً انتخاب کنید که می‌خواهید تبدیل از کدام مقیاس باشد:");
        Console.WriteLine("1. تبدیل از سلسیوس به فارنهایت");
        Console.WriteLine("2. تبدیل از فارنهایت به سلسیوس");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // تبدیل از سلسیوس به فارنهایت
            Console.Write("لطفاً دمای سلسیوس را وارد کنید: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} درجه سلسیوس برابر با {fahrenheit} درجه فارنهایت است.");
        }
        else if (choice == 2)
        {
            // تبدیل از فارنهایت به سلسیوس
            Console.Write("لطفاً دمای فارنهایت را وارد کنید: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} درجه فارنهایت برابر با {celsius} درجه سلسیوس است.");
        }
        else
        {
            Console.WriteLine("انتخاب نادرست! لطفاً یکی از گزینه‌های موجود را وارد کنید.");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ماشین حساب ساده");
        Console.WriteLine("-----------------");

        // دریافت اولین عدد
        Console.Write("عدد اول را وارد کنید: ");
        string input1 = Console.ReadLine();

        // دریافت دومین عدد
        Console.Write("عدد دوم را وارد کنید: ");
        string input2 = Console.ReadLine();

        // بررسی معتبر بودن ورودی
        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            // نمایش منوی عملیات
            Console.WriteLine("انتخاب عملیات:");
            Console.WriteLine("1. جمع");
            Console.WriteLine("2. تفریق");
            Console.WriteLine("3. ضرب");
            Console.WriteLine("4. تقسیم");
            Console.Write("شماره عملیات مورد نظر را وارد کنید: ");
            string operation = Console.ReadLine();

            // انجام عملیات
            switch (operation)
            {
                case "1":
                    Console.WriteLine($"نتیجه جمع: {number1 + number2}");
                    break;
                case "2":
                    Console.WriteLine($"نتیجه تفریق: {number1 - number2}");
                    break;
                case "3":
                    Console.WriteLine($"نتیجه ضرب: {number1 * number2}");
                    break;
                case "4":
                    if (number2 != 0)
                    {
                        Console.WriteLine($"نتیجه تقسیم: {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("خطا: تقسیم بر صفر امکان‌پذیر نیست.");
                    }
                    break;
                default:
                    Console.WriteLine("عملیات نامعتبر است.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("لطفاً اعداد معتبر وارد کنید.");
        }

        Console.Readkey();
    }
}

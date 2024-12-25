using System;

namespace SquareRootCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("محاسبه جذر عدد");

            // گرفتن ورودی عدد
            Console.Write("عدد را وارد کنید: ");
            double number = double.Parse(Console.ReadLine());

            // بررسی عدد منفی
            if (number < 0)
            {
                Console.WriteLine("جذر عدد منفی در اعداد حقیقی تعریف نشده است.");
            }
            else
            {
                // محاسبه جذر
                double result = Math.Sqrt(number);
                Console.WriteLine($"جذر {number} برابر است با {result}");
            }
        }
    }
}

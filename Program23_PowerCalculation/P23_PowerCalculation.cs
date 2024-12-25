using System;

namespace PowerCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("محاسبه توان (a^b)");

            // گرفتن ورودی عدد پایه (a)
            Console.Write("عدد پایه (a) را وارد کنید: ");
            int baseNumber = int.Parse(Console.ReadLine());

            // گرفتن ورودی توان (b)
            Console.Write("عدد توان (b) را وارد کنید: ");
            int exponent = int.Parse(Console.ReadLine());

            // محاسبه توان
            long result = 1; // مقدار اولیه 1
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber; // ضرب مکرر
            }

            Console.WriteLine($"{baseNumber} به توان {exponent} برابر است با {result}");
        }
    }
}

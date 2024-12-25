using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("تولید عدد تصادفی در بازه مشخص");

            // دریافت بازه از کاربر
            Console.Write("حداقل عدد: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("حداکثر عدد: ");
            int max = int.Parse(Console.ReadLine());

            // بررسی بازه
            if (min > max)
            {
                Console.WriteLine("حداقل نمی‌تواند بزرگ‌تر از حداکثر باشد!");
                return;
            }

            // تولید عدد تصادفی
            Random random = new Random();
            int randomNumber = random.Next(min, max + 1); // تولید عدد تصادفی بین min و max (شامل max)

            Console.WriteLine($"عدد تصادفی تولید شده: {randomNumber}");
        }
    }
}

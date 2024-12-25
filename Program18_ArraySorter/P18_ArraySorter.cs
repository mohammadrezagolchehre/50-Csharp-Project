using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("لطفاً اعداد را با فاصله از هم وارد کنید (مثال: 5 3 8 1 2):");
        string input = Console.ReadLine();

        // تبدیل رشته ورودی به آرایه‌ای از اعداد
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.WriteLine("چگونه مرتب‌سازی شود؟ (صعودی: 1، نزولی: 2):");
        string sortOrder = Console.ReadLine();

        if (sortOrder == "1")
        {
            // مرتب‌سازی صعودی
            Array.Sort(numbers); 
            Console.WriteLine("مرتب‌سازی صعودی:");
        }
        else if (sortOrder == "2")
        {
            // مرتب‌سازی صعودی
            Array.Sort(numbers);
            // معکوس کردن برای نزولی
            Array.Reverse(numbers);
            Console.WriteLine("مرتب‌سازی نزولی:");
        }
        else
        {
            Console.WriteLine("گزینه نامعتبر.");
            return;
        }
        // نمایش آرایه مرتب شده
        Console.WriteLine(string.Join(" ", numbers)); 
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("تعداد خطوط مثلث را وارد کنید:");
        int lines = int.Parse(Console.ReadLine());

        PrintStarTriangle(lines);
    }

    static void PrintStarTriangle(int n)
    {
        // حلقه برای خطوط
        for (int i = 1; i <= n; i++) 
        {
            // حلقه برای ستاره‌ها در هر خط
            for (int j = 1; j <= i; j++) 
            {
                Console.Write("*");
            }
            // رفتن به خط بعدی
            Console.WriteLine(); 
        }
    }
}

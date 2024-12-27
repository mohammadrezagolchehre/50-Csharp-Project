using System;

class Program
{
    static void Main()
    {
        // درخواست از کاربر برای وارد کردن تعداد کل کارها و تعداد کارهای انجام شده
        Console.Write("تعداد کل کارها را وارد کنید: ");
        int totalTasks = int.Parse(Console.ReadLine());

        Console.Write("تعداد کارهای انجام شده را وارد کنید: ");
        int completedTasks = int.Parse(Console.ReadLine());

        // محاسبه درصد پیشرفت
        if (totalTasks > 0)
        {
            double progress = ((double)completedTasks / totalTasks) * 100;
            Console.WriteLine($"درصد پیشرفت: {progress}%");
        }
        else
        {
            Console.WriteLine("تعداد کل کارها باید بزرگتر از صفر باشد.");
        }
    }
}

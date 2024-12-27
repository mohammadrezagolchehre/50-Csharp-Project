using System;

class Program
{
    static void Main()
    {
        int evenSum = 0;  // مجموع اعداد زوج
        int oddSum = 0;   // مجموع اعداد فرد

        // درخواست برای وارد کردن تعداد اعداد
        Console.Write("تعداد اعدادی که می‌خواهید وارد کنید را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        // حلقه برای وارد کردن اعداد و محاسبه مجموع
        for (int i = 1; i <= n; i++)
        {
            Console.Write("عدد شماره " + i + ": ");
            int num = int.Parse(Console.ReadLine());

            // بررسی اینکه عدد وارد شده فرد است یا زوج
            if (num % 2 == 0)
            {
                evenSum += num;  // افزودن به مجموع اعداد زوج
            }
            else
            {
                oddSum += num;   // افزودن به مجموع اعداد فرد
            }
        }

        // نمایش نتیجه
        Console.WriteLine("مجموع اعداد زوج: " + evenSum);
        Console.WriteLine("مجموع اعداد فرد: " + oddSum);
    }
}

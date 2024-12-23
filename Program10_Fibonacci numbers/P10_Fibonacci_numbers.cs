using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفاً حداکثر مقدار دنباله فیبوناچی را وارد کنید: ");
        int maxValue = int.Parse(Console.ReadLine());

        // متغیرهای اولیه برای دنباله فیبوناچی
        int first = 0, second = 1;

        // چاپ اعداد فیبوناچی تا مقدار مشخص
        Console.WriteLine("دنباله فیبوناچی:");
        Console.Write(first + " " + second + " ");

        while (true)
        {
            int next = first + second;
            if (next > maxValue)
                break;

            Console.Write(next + " ");
            first = second;
            second = next;
        }

        Console.WriteLine(); // خط جدید بعد از چاپ دنباله
    }
}

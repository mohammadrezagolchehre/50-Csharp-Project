using System;

class Program
{
    static void Main()
    {
        // نمایش جدول ضرب از 1 تا 10
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                // محاسبه و نمایش نتیجه ضرب
                Console.Write($"{i * j}\t");
            }
            // رفتن به خط جدید بعد از هر ردیف
            Console.WriteLine();
        }
    }
}

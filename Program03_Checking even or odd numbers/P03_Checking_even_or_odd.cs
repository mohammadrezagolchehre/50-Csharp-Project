using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        // بررسی زوج یا فرد بودن عدد و نمایش آن
        if (number % 2 == 0)
        {
            Console.WriteLine("عدد وارد شده زوج است.");
        }
        else
        {
            Console.WriteLine("عدد وارد شده فرد است.");
        }
    }
}

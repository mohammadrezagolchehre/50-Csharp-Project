using System;

class Program
{
    static void Main()
    {
        // گرفتن شعاع از کاربر
        Console.Write("لطفاً شعاع دایره را وارد کنید: ");
        double radius = double.Parse(Console.ReadLine());

        // محاسبه مساحت دایره
        double area = Math.PI * radius * radius;

        // نمایش مساحت دایره
        Console.WriteLine($"مساحت دایره با شعاع {radius} برابر با {area} است.");

        // مساحبه محیط دایره
        double Circumference = Math.PI * radius * 2;

        // نمایش محیط دایره
        Console.WriteLine($"محیط دایره با شعاع }{radius} براب است با {area}"

    }
}

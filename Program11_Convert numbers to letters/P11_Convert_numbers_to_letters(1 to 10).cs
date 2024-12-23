using System;

class Program
{
    static void Main()
    {
        // گرفتن ورودی از کاربر
        Console.Write("لطفا عدد مورد نظر خود را در محدوده 1 تا 10 وارد کنید :");
        int Value = int.Parse(Console.ReadLine());

        //بررسی عدد و تعیین خروجی مناسب
        switch (Value) {
            case 1
                Console.WriteLine("One");
                break;

            case 2
                Console.WriteLine("Two");
                break;

            case 3
                Console.WriteLine("Three");
                break;

            case 4
                Console.WriteLine("Four");
                break;

            case 5
                Console.WriteLine("Five");
                break;

            case 6
                Console.WriteLine("Six");
                break;

            case 7
                Console.WriteLine("Seven");
                break;

            case 8
                Console.WriteLine("Eight");
                break;

            case 9
                Console.WriteLine("Nine");
                break;

            case 10
                Console.WriteLine("Ten");

            default
                Console.WriteLine("عدد در محدوده 1 تا 10 نیست");
                break;


    }
}

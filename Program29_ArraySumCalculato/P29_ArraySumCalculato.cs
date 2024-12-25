using System;

class Program
{
    static void Main()
    {
        // آرایه نمونه
        int[] numbers = { 10, 20, 30, 40, 50 };

        // محاسبه مجموع
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // نمایش مجموع
        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}

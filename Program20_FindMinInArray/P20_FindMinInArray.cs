using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("تعداد عناصر آرایه را وارد کنید:");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("اعداد آرایه را وارد کنید:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"عدد {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int minNumber = FindMin(numbers);

        Console.WriteLine($"کوچک‌ترین عدد در آرایه: {minNumber}");
    }

    static int FindMin(int[] arr)
    {
        int min = arr[0]; // فرض می‌کنیم اولین عدد کوچک‌ترین است

        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num; // اگر عدد جاری کوچک‌تر بود، آن را به‌روزرسانی می‌کنیم
            }
        }

        return min;
    }
}

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

        int maxNumber = FindMax(numbers);

        Console.WriteLine($"بزرگ‌ترین عدد در آرایه: {maxNumber}");
    }

    static int FindMax(int[] arr)
    {
        int max = arr[0]; // فرض می‌کنیم اولین عدد بزرگ‌ترین است

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num; // اگر عدد جاری بزرگ‌تر بود، آن را به‌روزرسانی می‌کنیم
            }
        }

        return max;
    }
}

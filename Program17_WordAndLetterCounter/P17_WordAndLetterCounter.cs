using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("لطفاً یک جمله وارد کنید:");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        int letterCount = CountLetters(input);

        Console.WriteLine($"تعداد کلمات: {wordCount}");
        Console.WriteLine($"تعداد حروف: {letterCount}");
    }

    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static int CountLetters(string text)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c)) // بررسی حروف
                count++;
        }

        return count;
    }
}

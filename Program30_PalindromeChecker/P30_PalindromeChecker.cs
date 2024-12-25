using System;

class Program
{
    static void Main()
    {
        // دریافت ورودی از کاربر
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // حذف فضاهای خالی و تبدیل به حروف کوچک
        string cleanedInput = input.Replace(" ", "").ToLower();

        // بررسی پالیندروم بودن
        bool isPalindrome = true;
        int length = cleanedInput.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (cleanedInput[i] != cleanedInput[length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        // نمایش نتیجه
        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}

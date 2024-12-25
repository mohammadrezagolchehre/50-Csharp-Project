using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("یک حرف وارد کنید:");
        // تبدیل حرف به حرف کوچک برای جلوگیری از اختلال و سازگاری
        char input = char.ToLower(Console.ReadKey().KeyChar);
        // برای نمایش خروجی در خط دیگر
        Console.WriteLine();

        //بررسی ورودی با تابع تشخیص حروف صدادار
        if (IsVowel(input))
        {
            Console.WriteLine($"حرف '{input}' یک حرف صدادار است.");
        }
        else
        {
            Console.WriteLine($"حرف '{input}' یک حرف صدادار نیست.");
        }
    }

    static bool IsVowel(char c)
    {
        // بررسی حروف صدادار
        return "aeiou".Contains(c);

        //contains: یک متد داخلی در سی‌شارپ است که بررسی می‌کند آیا کاراکتر یا زیررشته‌ای در رشته اصلی وجود دارد یا خیر
    }
}

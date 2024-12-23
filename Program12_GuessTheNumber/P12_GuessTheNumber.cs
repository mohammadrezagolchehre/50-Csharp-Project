using System;

class Program
{
    static void Main()
    {
        // تولید عدد تصادفی بین 1 و 100
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        // متغیر برای ذخیره تعداد حدس‌ها
        int guessCount = 0;
        int userGuess;

        Console.WriteLine("به بازی حدس عدد خوش آمدید!");
        Console.WriteLine("من یک عدد بین 1 و 100 انتخاب کرده‌ام. تلاش کنید آن را حدس بزنید.");

        // حلقه حدس زدن
        do
        {
            Console.Write("لطفاً یک عدد وارد کنید: ");
            userGuess = int.Parse(Console.ReadLine());
            guessCount++;

            if (userGuess < randomNumber)
            {
                Console.WriteLine("عدد وارد شده کمتر از عدد تصادفی است. دوباره تلاش کنید!");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("عدد وارد شده بزرگتر از عدد تصادفی است. دوباره تلاش کنید!");
            }
            else
            {
                Console.WriteLine($"تبریک! شما عدد {randomNumber} را درست حدس زدید. تعداد تلاش‌ها: {guessCount}");
            }

        } while (userGuess != randomNumber);
    }
}

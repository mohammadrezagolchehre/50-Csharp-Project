using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Voting System");

        // تعریف لیست گزینه‌های رأی
        List<string> options = new List<string> { "Option 1", "Option 2", "Option 3" };
        Dictionary<string, int> votes = new Dictionary<string, int>();

        // مقداردهی اولیه به تعداد آرا
        foreach (var option in options)
        {
            votes[option] = 0;
        }

        bool votingActive = true;
        while (votingActive)
        {
            Console.WriteLine("\nPlease vote by entering the option number:");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.WriteLine($"{options.Count + 1}. Finish voting");

            string input = Console.ReadLine();

            // بررسی ورودی کاربر
            if (int.TryParse(input, out int optionNumber) && optionNumber >= 1 && optionNumber <= options.Count)
            {
                string selectedOption = options[optionNumber - 1];
                votes[selectedOption]++;
                Console.WriteLine($"You voted for {selectedOption}");
            }
            else if (int.TryParse(input, out int finishOption) && finishOption == options.Count + 1)
            {
                votingActive = false;
                Console.WriteLine("Voting finished. Here are the results:");
                DisplayResults(votes);
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void DisplayResults(Dictionary<string, int> votes)
    {
        foreach (var vote in votes)
        {
            Console.WriteLine($"{vote.Key}: {vote.Value} votes");
        }
    }
}

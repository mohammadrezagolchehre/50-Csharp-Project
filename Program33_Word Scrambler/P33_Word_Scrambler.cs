using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Word Scrambler");
        Console.WriteLine("Enter a word to scramble:");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid word.");
            return;
        }

        string scrambledWord = ScrambleWord(input);
        Console.WriteLine($"Original word: {input}");
        Console.WriteLine($"Scrambled word: {scrambledWord}");
    }

    static string ScrambleWord(string word)
    {
        char[] characters = word.ToCharArray();
        Random random = new Random();

        for (int i = characters.Length - 1; i > 0; i--)
        {
            int randomIndex = random.Next(i + 1);
            char temp = characters[i];
            characters[i] = characters[randomIndex];
            characters[randomIndex] = temp;
        }

        return new string(characters);
    }
}

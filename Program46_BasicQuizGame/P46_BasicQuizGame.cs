using System;

class BasicQuizGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Basic Quiz Game!");
        Console.WriteLine("--------------------------------");

        int score = 0; // امتیاز کاربر

        // سؤال اول
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("   a) Berlin");
        Console.WriteLine("   b) Madrid");
        Console.WriteLine("   c) Paris");
        Console.WriteLine("   d) Rome");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine().ToLower();

        if (answer1 == "c")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The correct answer is c) Paris.");
        }

        Console.WriteLine();

        // سؤال دوم
        Console.WriteLine("2. What is 5 + 3?");
        Console.WriteLine("   a) 6");
        Console.WriteLine("   b) 8");
        Console.WriteLine("   c) 10");
        Console.WriteLine("   d) 12");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine().ToLower();

        if (answer2 == "b")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The correct answer is b) 8.");
        }

        Console.WriteLine();

        // سؤال سوم
        Console.WriteLine("3. Which planet is known as the Red Planet?");
        Console.WriteLine("   a) Earth");
        Console.WriteLine("   b) Venus");
        Console.WriteLine("   c) Mars");
        Console.WriteLine("   d) Jupiter");
        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine().ToLower();

        if (answer3 == "c")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The correct answer is c) Mars.");
        }

        Console.WriteLine();

        // نمایش امتیاز نهایی
        Console.WriteLine($"Your final score is: {score}/3");

        // ارزیابی عملکرد
        if (score == 3)
        {
            Console.WriteLine("Excellent! You got all the answers correct!");
        }
        else if (score == 2)
        {
            Console.WriteLine("Good job! You got 2 answers correct.");
        }
        else if (score == 1)
        {
            Console.WriteLine("You got 1 answer correct. Keep practicing!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Basic Countdown Timer");
        Console.WriteLine("Enter the countdown time in seconds:");

        int countdownTime;
        if (int.TryParse(Console.ReadLine(), out countdownTime) && countdownTime > 0)
        {
            StartCountdown(countdownTime);
        }
        else
        {
            Console.WriteLine("Please enter a valid number greater than 0.");
        }
    }

    static void StartCountdown(int time)
    {
        Console.Clear();
        while (time > 0)
        {
            Console.Clear();
            Console.WriteLine($"Time remaining: {time} seconds");
            Thread.Sleep(1000); // wait for 1 second
            time--;
        }

        Console.Clear();
        Console.WriteLine("Time's up!");
    }
}

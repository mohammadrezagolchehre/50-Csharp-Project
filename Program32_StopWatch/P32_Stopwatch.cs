using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Stopwatch Program");
        Console.WriteLine("Press 'S' to start, 'E' to stop, and 'R' to reset.");
        Console.WriteLine("Press 'Q' to quit.");

        Stopwatch stopwatch = new Stopwatch();
        bool running = true;

        while (running)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.S:
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                        Console.WriteLine("Stopwatch started.");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is already running.");
                    }
                    break;

                case ConsoleKey.E:
                    if (stopwatch.IsRunning)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Stopwatch stopped at: {stopwatch.Elapsed}");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is not running.");
                    }
                    break;

                case ConsoleKey.R:
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset.");
                    break;

                case ConsoleKey.Q:
                    running = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid key. Use 'S', 'E', 'R', or 'Q'.");
                    break;
            }
        }
    }
}

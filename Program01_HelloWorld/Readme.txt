# README

## Description
This project demonstrates a simple C# console application that prints a greeting message, "Hello, World!" after a short delay. It is intended to showcase the basics of using the `Console.WriteLine` method and incorporating a delay using the `Thread.Sleep` method.

## Code Explanation
Here is the breakdown of the code:

### Code Snippet
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Loading...");

        // Wait for one second
        Thread.Sleep(1000);

        // Print the greeting message
        Console.WriteLine("Hello, World!");
    }
}
```

### Key Points
1. **`using System;`**
   - This directive allows the use of basic .NET functionality, such as console input/output.

2. **`Console.WriteLine("Loading...");`**
   - Prints the text "Loading..." to the console output.

3. **`Thread.Sleep(1000);`**
   - Pauses the program for 1000 milliseconds (1 second). This simulates a loading delay.

4. **`Console.WriteLine("Hello, World!");`**
   - Prints the text "Hello, World!" to the console output.

## How to Run
1. **Prerequisites:**
   - Install the .NET SDK on your machine if not already installed.
   - Ensure your environment supports C# (e.g., Visual Studio, Visual Studio Code with C# extension).

2. **Steps to Execute:**
   - Save the code into a file named `Program.cs`.
   - Open a terminal or command prompt in the directory containing the file.
   - Compile the program using the following command:
     ```
     dotnet build
     ```
   - Run the program using this command:
     ```
     dotnet run
     ```

3. Observe the output in the console:
   - "Loading..."
   - After one second: "Hello, World!"

## Purpose
This example serves as a starting point for understanding basic C# programming concepts like console output, namespaces, and thread control.

## Customization
Feel free to modify the text or delay duration to personalize the program. For instance, you can change the delay to 2 seconds by updating `Thread.Sleep(1000);` to `Thread.Sleep(2000);`.

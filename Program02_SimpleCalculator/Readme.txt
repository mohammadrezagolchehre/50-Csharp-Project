# README

## Description
This is a simple console-based calculator program written in C#. It allows users to perform basic arithmetic operations, including addition, subtraction, multiplication, and division.

## Code Explanation
Here is the breakdown of the code:

### Code Snippet
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ماشین حساب ساده");
        Console.WriteLine("-----------------");

        // دریافت اولین عدد
        Console.Write("عدد اول را وارد کنید: ");
        string input1 = Console.ReadLine();

        // دریافت دومین عدد
        Console.Write("عدد دوم را وارد کنید: ");
        string input2 = Console.ReadLine();

        // بررسی معتبر بودن ورودی
        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            // نمایش منوی عملیات
            Console.WriteLine("انتخاب عملیات:");
            Console.WriteLine("1. جمع");
            Console.WriteLine("2. تفریق");
            Console.WriteLine("3. ضرب");
            Console.WriteLine("4. تقسیم");
            Console.Write("شماره عملیات مورد نظر را وارد کنید: ");
            string operation = Console.ReadLine();

            // انجام عملیات
            switch (operation)
            {
                case "1":
                    Console.WriteLine($"نتیجه جمع: {number1 + number2}");
                    break;
                case "2":
                    Console.WriteLine($"نتیجه تفریق: {number1 - number2}");
                    break;
                case "3":
                    Console.WriteLine($"نتیجه ضرب: {number1 * number2}");
                    break;
                case "4":
                    if (number2 != 0)
                    {
                        Console.WriteLine($"نتیجه تقسیم: {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("خطا: تقسیم بر صفر امکان‌پذیر نیست.");
                    }
                    break;
                default:
                    Console.WriteLine("عملیات نامعتبر است.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("لطفاً اعداد معتبر وارد کنید.");
        }

        Console.Readkey();
    }
}
```

### Key Points
1. **Input Validation:**  
   The program validates that the inputs are valid numbers using `double.TryParse`.

2. **Operation Menu:**  
   Users can select one of the following operations:
   - `1` for addition
   - `2` for subtraction
   - `3` for multiplication
   - `4` for division

3. **Division by Zero Check:**  
   The program ensures that division by zero is not performed and displays an error message if attempted.

4. **Invalid Operation Handling:**  
   If the user selects an invalid operation, an error message is displayed.

## How to Run
1. **Prerequisites:**  
   - Install the .NET SDK on your system.
   - Ensure your development environment supports C# (e.g., Visual Studio, Visual Studio Code).

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

3. **Usage:**  
   - Enter two numbers when prompted.
   - Select an operation from the menu.
   - View the result in the console.

## Customization
You can expand this calculator to include additional operations such as modulus, exponentiation, or advanced mathematical functions.


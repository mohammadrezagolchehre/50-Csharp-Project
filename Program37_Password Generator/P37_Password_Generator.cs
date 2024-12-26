using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Password Generator");
        Console.WriteLine("Enter the length of the password:");

        int length;
        if (int.TryParse(Console.ReadLine(), out length) && length > 0)
        {
            string password = GeneratePassword(length);
            Console.WriteLine($"Generated Password: {password}");
        }
        else
        {
            Console.WriteLine("Please enter a valid length (greater than 0).");
        }
    }

    static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(validChars.Length);
            password.Append(validChars[index]);
        }

        return password.ToString();
    }
}

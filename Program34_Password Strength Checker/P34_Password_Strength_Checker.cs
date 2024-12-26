using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Password Strength Checker");
        Console.WriteLine("Enter a password to check its strength:");

        string password = Console.ReadLine();
        string strength = CheckPasswordStrength(password);

        Console.WriteLine($"Password: {password}");
        Console.WriteLine($"Strength: {strength}");
    }

    static string CheckPasswordStrength(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return "Invalid (Password cannot be empty)";
        }

        int score = 0;

        // Length check
        if (password.Length >= 8) score++;

        // Uppercase letter check
        if (Regex.IsMatch(password, @"[A-Z]")) score++;

        // Lowercase letter check
        if (Regex.IsMatch(password, @"[a-z]")) score++;

        // Digit check
        if (Regex.IsMatch(password, @"\d")) score++;

        // Special character check
        if (Regex.IsMatch(password, @"[!@#$%^&*(),.?\":{}|<>]")) score++;

        // Determine strength based on score
        return score switch
        {
            5 => "Very Strong",
            4 => "Strong",
            3 => "Moderate",
            2 => "Weak",
            _ => "Very Weak"
        };
    }
}

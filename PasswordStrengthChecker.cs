using System;
using System.Text.RegularExpressions;

class PasswordStrengthChecker
{
    static void Main()
    {
        Console.Write("Enter a password to check its strength: ");
        string password = Console.ReadLine();

        int score = 0;

        // Rule 1: Length
        if (password.Length >= 8)
            score++;
        else
            Console.WriteLine("Password must be at least 8 characters long.");

        // Rule 2: Contains lowercase
        if (Regex.IsMatch(password, "[a-z]"))
            score++;

        // Rule 3: Contains uppercase
        if (Regex.IsMatch(password, "[A-Z]"))
            score++;

        // Rule 4: Contains digit
        if (Regex.IsMatch(password, "[0-9]"))
            score++;

        // Rule 5: Contains special character
        if (Regex.IsMatch(password, @"[!@#$%^&*(),.?\":{}|<>]"))
            score++;

        // Evaluate strength
        string strength = score switch
        {
            5 => "Very Strong",
            4 => "Strong",
            3 => "Medium",
            2 => "Weak",
            _ => "Very Weak"
        };

        Console.WriteLine($"Password Strength: {strength} ({score}/5)");
    }
}

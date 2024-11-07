using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome! Please type your password:");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your password must meet the following criteria:");
        Console.WriteLine("1. At least one uppercase letter (A-Z)");
        Console.WriteLine("2. At least one number (0-9)");
        Console.WriteLine("3. At least one special character (e.g., !, @, #, $)");
        Console.WriteLine("4. Minimum length of 8 characters");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Type your password: ");
        Console.ResetColor();

        string password = Console.ReadLine();

        if (IsValidPassword(password))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Password is valid!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password does not meet the criteria.");
        }
        Console.ResetColor();
    }

    static bool IsValidPassword(string password)
    {
        if (password.Length < 8)
            return false;

        if (!Regex.IsMatch(password, @"[A-Z]"))
            return false;

        if (!Regex.IsMatch(password, @"[0-9]"))
            return false;

        if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?\"":{}|<>]")) // regex pattern
            return false;

        return true;
    }
}

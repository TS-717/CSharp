using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        if (input == reversed)
            Console.WriteLine("It's a palindrome.");
        else
            Console.WriteLine("Not a palindrome.");
    }
}

using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        char op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Division by zero error.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}

// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        try
        {

            Console.Write("Enter a Number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another Number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter an Operation(+,-,/,*): ");
            char op = char.Parse(Console.ReadLine());
            double result = 0;
            bool There_is_an_error = false;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero error!");
                        There_is_an_error = true;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.Write("Invalid Operation Entered");
                    There_is_an_error = true;
                    break;
            }
            if (!There_is_an_error)
            {
                Console.WriteLine($"Result: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Non-numeric value entered!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{
    try
    {
        Console.WriteLine("Enter the first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /): ");

        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid Operation");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by zero.");
    }
    finally
    {
        Console.WriteLine("Operation completed");
    }
}
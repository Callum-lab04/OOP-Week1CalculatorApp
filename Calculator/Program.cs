// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{
    // Declare the variables and initialise them to 0
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    // Ask the user to input the first number
    Console.WriteLine("Type in the first number, and then press Enter");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask the user to input the second number
    Console.WriteLine("Type in the second number, and then press Enter");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // Use a loop to make the relevant decision
    // and perform the request maths operation
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    // Convert string to integer
    choice = Convert.ToInt32(Console.ReadLine());

    // perform the calculation
    result = firstNumber + secondNumber;

    // Now input the answer to the console
    Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);
}
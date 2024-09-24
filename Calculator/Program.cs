// See https://aka.ms/new-console-template for more information

Console.WriteLine("Type in the first number, and then press Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number, and then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);

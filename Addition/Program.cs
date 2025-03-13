// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the first number : ");
double firstNumber = 0.0;
double secondNumber = 0.0;
double sum = 0.0;
firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number : ");
secondNumber = double.Parse(Console.ReadLine());
sum = firstNumber + secondNumber;
Console.WriteLine($"The sum is : {Math.Round(sum,2)}");
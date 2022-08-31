// Напишите программу, которая на вход принимает число и выдает его квадрат.
// (число умноженное само на себя)
Console.Clear();

Console.WriteLine("Enter the number: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"Square of number {number} is {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Square of number {number} is {sqr1}");
//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.Clear();

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Yes - {a} is e square of {b}");
}
else
{
    Console.WriteLine($"No - {a} is not square of {b}");
}

// ONE MORE SOLUTION
//Console.Write("Entrer two numbers: ");
//string[] num = Console.ReadLine().Split(' ');
//int a = int.Parse(num[0]);
//int b = int.Parse(num[1]);
//
//if (a == b * b)
//{
//    Console.WriteLine($"Yes - {a} is e square of {b}");
//}
//else
//{
//    Console.WriteLine($"No - {a} is not square of {b}");
//}
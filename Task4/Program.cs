//7. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Clear();
Console.Write("Enter three digits number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(a % 10);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.Write("Enter three numbers: ");
string[] num = Console.ReadLine().Split(' ');

int a = int.Parse(num[0]);
int b = int.Parse(num[1]);
int c = int.Parse(num[2]);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");


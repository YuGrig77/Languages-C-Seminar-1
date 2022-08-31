//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
//число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());

if (0 == a % 2)
{
    Console.WriteLine($"{a} -> да, четное");
}
else
{
    Console.WriteLine($"{a} -> нет, не четное");
}
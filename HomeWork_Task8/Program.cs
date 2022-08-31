//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());

int n = 1;

while (n <= a)
{
    if (n % 2 == 0)
    {
        Console.Write($"{n}, ");
        n++;
    }
    else
    {
        n++;
    }
}

// or second version:

//Console.Write("Enter number: ");
//int a = int.Parse(Console.ReadLine());
//
//for (int n = 2; n <= a; n += 2)
//{
//    Console.Write($"{n}, ");
//}









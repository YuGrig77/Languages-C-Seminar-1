//Напишите программу, которая будет выдавать название дня недели 
//по заданному номеру.
//3 -> Среда
//5 -> Пятница

//Через массив:

string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите номер дня недели (от 1 до 7)");
int num = int.Parse(Console.ReadLine());

if (num <= 7 && num >= 1)
{
    Console.WriteLine($"День недели - {day[num - 1]}");
}
else
{
    Console.WriteLine("Введенное число не корректно");
}

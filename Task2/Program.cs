//Напишите программу, которая будет выдавать название дня недели 
//по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Clear();

Console.WriteLine("Enter Week's day number: ");
int day = int.Parse(Console.ReadLine());

if(day == 1) Console.Write("It is Monday");
if(day == 2) Console.Write("It is Tuesday");
if(day == 3) Console.Write("It is Wednesday");
if(day == 4) Console.Write("It is Thursday");
if(day == 5) Console.Write("It is Friday");
if(day == 6) Console.Write("It is Saturday");
if(day == 7) Console.Write("It is Sunday");
if(day > 7) Console.WriteLine("Come on, it's a week!");
// or last line could be
//else {Console.WriteLine("Come on, it's a week!")};

//Через массив:
//string[] days = {"Понедельник, "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//Console.WriteLine("Введите номер дня недели (от 1 до 7)");
//int num = int.Parse(Console.ReadLine());
//
//if (num <= 7 && num => 1)
//{
//    Console.WriteLine($"День недели - {day[num-1]}");
//}
//else
//{
//  Console.WriteLine("Введенное число не корректно");
//}
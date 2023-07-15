/*Напишите программу, которая будет выдавать название дня недли
по заданному числу.*/

Console.Clear();
Console.Write("Введите число дня недели: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {DayOfWeek};");

while (DayOfWeek < 1 || DayOfWeek > 7)
{
   Console.WriteLine("Введено неправильное число.");
   Console.Write("Введите правильное число дня недели(от 1 до 7). ");
   DayOfWeek = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   Console.WriteLine($"Вы ввели число: {DayOfWeek};");
}

if (DayOfWeek == 1) Console.WriteLine("Это будет: Понедельник.");
if (DayOfWeek == 2) Console.WriteLine("Это будет: Вторник.");
if (DayOfWeek == 3) Console.WriteLine("Это будет: Среда.");
if (DayOfWeek == 4) Console.WriteLine("Это будет: Четверг.");
if (DayOfWeek == 5) Console.WriteLine("Это будет: Пятница.");
if (DayOfWeek == 6) Console.WriteLine("Это будет: Суббота.");
if (DayOfWeek == 7) Console.WriteLine("Это будет: Воскресенье.");
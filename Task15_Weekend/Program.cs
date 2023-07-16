/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, проверяет является ли этот день 
выходным.*/
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели цифру: {DayOfWeek};");

while (DayOfWeek < 1 || DayOfWeek > 7)
{
   Console.WriteLine("Введена неправильная цифра.");
   Console.Write("Введите правильную цифру дня недели(от 1 до 7). ");
   DayOfWeek = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   Console.WriteLine($"Вы ввели цифру: {DayOfWeek};");
}

if (DayOfWeek == 1) Console.WriteLine("Понедельник. Не выходной, а рабочий день недели.");
if (DayOfWeek == 2) Console.WriteLine("Вторник. Не выходной, а рабочий день недели.");
if (DayOfWeek == 3) Console.WriteLine("Среда. Не выходной, а рабочий день недели.");
if (DayOfWeek == 4) Console.WriteLine("Четверг. Не выходной, а рабочий день недели.");
if (DayOfWeek == 5) Console.WriteLine("Пятница. Не выходной, а рабочий день недели.");
if (DayOfWeek == 6) Console.WriteLine("Суббота. Выходной день недели.");
if (DayOfWeek == 7) Console.WriteLine("Воскресенье. Выходной день недели.");

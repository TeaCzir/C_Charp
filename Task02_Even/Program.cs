/*Напишите программу, которая на вход принимает число
и выдает, является ли оно четным. (делится ли оно на два 
без остатка.*/
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write($"Вы ввели число: {num};");
Console.WriteLine();
if (num % 2 == 0)
   Console.Write($"Число: {num} четное;");
else Console.Write($"Число: {num} нечетное;");
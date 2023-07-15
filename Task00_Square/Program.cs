/*Напишите программу, которая на вход принимает число и 
выдает его квадрат.*/
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");
Console.WriteLine($"Квадрат числа: {num} равен {num * num};");

/*Напишите программу, которая принимает на вход трехзначное 
число и на выходе показывает вторую цифру этого числа.*/
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");
int lastwo = num % 100;
int second = lastwo /10;

Console.Write($"Вторая цифра числа: {second};");


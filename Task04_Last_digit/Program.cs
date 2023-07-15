/*Напишите программу, которая на вход принимает трехзначное 
число, а на выход показывает последнюю цифру этого числа.*/
Console.Clear();
Console.Write("Введите трехзначое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");

int LastDigit = num % 10;
Console.Write($"Последняя цифра: {LastDigit};");
/*Напишите программу, которая на вход принимает одно
число, а на выходе показывает все целые числа от - N до N.*/

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");
Console.WriteLine($"Числа от -{num} до {num}:");
for (int i = -num; i < num + 1; i++)
{
Console.Write($"{i}; ");
}

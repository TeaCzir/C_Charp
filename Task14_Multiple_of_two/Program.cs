/*Напишите программу, которая принимает на вход число 
и проверяет кратно ли оно одновременно 7 и 23.*/
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");
if (num % (7 * 23) == 0)

   Console.Write($"Да, число: {num} кратно 7 и 23;");
else
   Console.Write($"Нет, число: {num} некратно одновременно 7 и 23;");

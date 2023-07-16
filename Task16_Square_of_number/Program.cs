/*Напишите программу, которая на вход принимает два числа 
и проверяет, является ли одно число квадратом другого.*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num1} и число: {num2};");

if (num1 == num2 * num2 || num2 == num1 * num1)
   Console.Write($"Да, одно из чисел является квадратом другого;");
else
   Console.Write($"Нет ни одно из чисел не является квадратом другого;");

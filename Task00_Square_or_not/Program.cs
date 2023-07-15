/*Напишите программу, которая на вход принимает два числа и 
проверяет, является ли первое квадратом второго.*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write($"Вы ввели число: {num1} и число: {num2};");
Console.WriteLine();

if (num1 == num2*num2)
{
   Console.Write($"Число: {num1} является квадратом числа: {num2};");
}
else 
Console.Write($"Число: {num1} не квадрат числа: {num2};");
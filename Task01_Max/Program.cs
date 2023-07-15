/*Напишите программу, которая на вход принимает два числа
и выдает, какое число больше, а какое меньше.*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"Вы ввели числа: {num1}, {num2};");
Console.WriteLine();
int max = num1;
int min = num2;
if(num2 > num1)
{
max = num2;
Console.Write($"Максимальное число: {num2}, ");

Console.Write($"а число: {num1} минимальное.");
} 
else
{
max = num1;
Console.Write($"Максимальное число: {num1}, ");

Console.Write($"а число: {num2} минимальное.");
}
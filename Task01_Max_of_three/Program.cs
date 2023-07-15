/*Напишите программу, которая на вход принимает три числа 
и выдает максимальное из этих трех чисел.*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"Вы ввели три числа: {num1}, {num2}, {num3};");
Console.WriteLine();
int max = num1;
if(num2 > num1) max = num2;
if(num3 > num2) max = num3;
Console.Write($"Максимальное число: {max};");
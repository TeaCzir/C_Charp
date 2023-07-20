/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Clear();
Console.Write("Введите первое число: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());

double degree = Math.Pow(A, B);

Console.Clear();
Console.WriteLine($"Вы ввели число: {A} и число: {B},");
Console.WriteLine($"Число {A} в степени {B} будет равно: {degree}.");

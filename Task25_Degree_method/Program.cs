// See https://aka.ms/new-console-template for more information
/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {A} и число: {B},");

int Met(int s, int p)
{
int degree = 1;
for (int i = 1; i <= p; i++)
{
   degree *= s;
}
return degree;
}
int Deg = Met(A, B);
Console.WriteLine($"Число {A} в степени {B} будет равно: {Deg}.");
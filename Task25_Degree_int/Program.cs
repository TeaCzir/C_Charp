/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {A} и число: {B},");
int degree = 1;
for (int i = 1; i <= B; i++)
{
   degree *= A;
}


Console.WriteLine($"Число {A} в степени {B} будет равно: {degree}.");
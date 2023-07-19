/*Напишите программу с использованием метода, которая 
на вход принимает число А, и на выход выдает сумму всех 
чисел от 1 го до А.*/

Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {A};");

int Method(int s)
{
int sum = 0;
for (int i = 1; i <= s; i++)
{
   sum+=i;//sum = sum + i;
}
return sum;
}
int Sumnum = Method(A);
Console.Write($"Сумма чисел от 1 до А: {Sumnum};");

/*Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.*/

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int recSum(int num)
{
   if (num != 0)
   {
      return num % 10 + recSum(num / 10);
   }
   return 0;
}

Console.WriteLine($"Сумма цифр числа: {N} равняеется: {recSum(N)};");


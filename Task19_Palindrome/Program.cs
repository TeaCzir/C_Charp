/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/
Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {a};");

if (a < 99999 & a >= 10000)
{
   int xx = a / 1000;
   int num1 = xx / 10;
   int num2 = xx % 10;
   int yy = a % 100;
   int num3 = yy / 10;
   int num4 = yy % 10;
if((num1 == num4)&(num2==num3))
Console.WriteLine($"Число: {a} является палиндромом;");
else
Console.WriteLine($"Число: {a} не палиндром;");
}
else
Console.WriteLine("Это не пятизначное число.");
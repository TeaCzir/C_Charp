/*Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.*/
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {a};");
int Num(int c)
{
   int sum = 0;
   for (int i = 0; c > 0; i++)
   {
      sum += c % 10;
      c /= 10;
   }
   return (sum);
}
Console.WriteLine($"Сумма цифр в числе равна: {Num(a)};");
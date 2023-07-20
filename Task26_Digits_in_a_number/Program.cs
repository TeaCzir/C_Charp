/*Напишите программу, которая на вход принимает число и на выход 
выдает колличество цифр этого числа.*/
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Dig(int s)
{
   int count = 0;
   if (s < 0) s *= (-1);
   while (s > 0)
   {
      s /= 10;
      count++;
   }
   return count;
}
Console.Clear();
Console.WriteLine($"Вы ввели число: {a};");
Console.WriteLine($"Колличество цифр: {Dig(a)};");

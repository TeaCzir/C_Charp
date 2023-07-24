/*Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1. */
ulong[] Fib(int n)
{
   ulong[] mas_f = new ulong[n];
   mas_f[0] = 0;
   if (n >= 2)
      mas_f[1] = 1;
   for (int i = 2; i < n; i++)
   {
      mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
   }
   return mas_f;
}

Console.Clear();
Console.Write("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n};");
System.Console.WriteLine($"Первые n чисел Фибоначчи: ");
Console.WriteLine($"[{String.Join(' ', Fib(n))}]");


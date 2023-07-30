/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

Console.Clear();
uint m = NumInp("Введите M: ");
uint n = NumInp("Введите N: ");

uint functionAkkerman = Akkerman(m, n);

Console.Write($"Функция Аккермана: {functionAkkerman};");


uint Akkerman(uint n, uint m)
{
   if (n == 0)
      return m + 1;
   else
     if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
   else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

uint NumInp(string input)
{
   Console.Write(input);
   uint output = Convert.ToUInt32(Console.ReadLine());
   return output;
}



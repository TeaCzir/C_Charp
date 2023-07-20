/*Напишите программу, которая принимает число N, и выдает 
произведение чисел от 1 до N.*/
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {a};");

int PrNum(int d)
{
   int zum = 1;
   for (int i = 1; i <= d; i++) zum *= i;
   return zum;
}

Console.WriteLine($"Произведение чисел от 1 до {a} равно: {PrNum(a)};");
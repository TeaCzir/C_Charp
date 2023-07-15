/*Напишите программу, которая на вход принимает число (N), а
на выходе показывает все четные числа от 1 до N.*/
Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {N};");
Console.WriteLine($"Четные числа от 1 до {N}: ");
Console.Write("(");
for (int i = 2; i <= N; i+=2)
{
   Console.Write($"{i}");
   Console.Write(", ");
}
Console.Write(");");
/*/*Напишите программу, которая на вход принимает число А, 
и на выход выдает сумму всех чисел от 1 го до А.*/

Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {A};");

int Sum = 0;
for (int i = 1; i <= A; i++)
{
   Sum += i;
}
Console.Write($"Сумма чисел от 1 до А: {Sum};");

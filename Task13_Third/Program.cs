/*Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.*/
Console.Clear();
Console.Write("Введите число в интервале от -2147483648 до 2147483647: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {num};");
if (num / 100 == 0)
   Console.Write($"В числе: {num} нет третьей цифры;");
else
{
   while (num / 1000 != 0)
   {
      num = num / 10;
   }
   int Third = num % 10;
   Console.Write($"Третья цифра: {Third};");
}


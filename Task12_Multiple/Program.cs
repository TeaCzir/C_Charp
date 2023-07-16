/*Напишите программу, которая будет принимать на вход два 
числа и выводить, является ли второе число кратным первому. 
Если нет то программа выводит остаток от деления.*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели первое: {num1} второе: {num2} числа;");
if (num1 % num2 == 0)
   Console.Write($"Число: {num2} кратно числу: {num1};");
else
{
   Console.WriteLine($"Число: {num2} некратно числу: {num1};");
   Console.Write($"Остаток деления равен: {num1 % num2};");
}

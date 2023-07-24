/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/
Console.Clear();
double k1 = input("Введите k1: ");
double b1 = input("Введите b1: ");
double k2 = input("Введите k2: ");
double b2 = input("Введите b2: ");

Console.Clear();
Console.WriteLine($"Вы ввели: b1 = {b1}; k1 = {k1}; b2 = {b2}; k2 = {k2};");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Точка пересечения: ({x}; {y};)");

double input(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}
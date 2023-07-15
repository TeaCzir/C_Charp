/*Напишите программу, которая выводит случайное число из
отрезка [10, 99] и показывает наибольшую цифру этого числа.
*/
Console.Clear();
int randnum = new Random().Next(10, 100);

Console.WriteLine($"Случайное число: {randnum};");
int past = randnum % 10;
int first = randnum / 10;

int max = past;

if (first > past) max = first;

Console.Write($"Наибольшая цифра числа: {max};");
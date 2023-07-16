/*Напишите программу, которая выводит случайное трехзначное 
число и удаляет вторую цифру этого числа.*/
Console.Clear();
int randnum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randnum};");
int result = (randnum/100)*10 + randnum%10;
Console.WriteLine($"Удаляем вторую цифру и получаем: {result};");

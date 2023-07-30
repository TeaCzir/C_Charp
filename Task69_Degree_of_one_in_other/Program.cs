/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в натуральную степень B с помощью рекурсии.*/
using System;
using static System.Console;


Clear();
Write("Введите число: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите степень: ");
int B = Convert.ToInt32(ReadLine());

WriteLine($"{Pow(A, B)}");


int Pow(int number, int rank)
{
    if (rank == 0) 
        return 1;
    return (number * Pow(number, rank - 1));
}

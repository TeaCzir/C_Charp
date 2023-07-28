/*Задайте двухмерный массив. Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1,1); и т.д.*/

using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(m);
        }

    }
    return result;
}

int GetSumDiag(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? 
    array.GetLength(0) : array.GetLength(1);
    // if (array.GetLength(0) < array.GetLength(1))
    //     length = array.GetLength(0);
    // else
    //     length = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

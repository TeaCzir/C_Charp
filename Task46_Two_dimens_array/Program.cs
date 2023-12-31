﻿/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.*/


using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
   int[,] result = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         result[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return result;
}

void PrintArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j]} ");
      }
      WriteLine();
   }
}

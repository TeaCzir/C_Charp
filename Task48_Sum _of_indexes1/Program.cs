/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: A[i][j] = i + j. Выведите полученный массив на экран.*/

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int m, int n)
{
   int[,] result = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         result[i, j] = i + j;
      }
   }
   return result;
}

void PrintArray(int[,] inArray)
{
   Write($"[ ]\t");
   for (int i = 0; i < inArray.GetLength(1); i++)
   {
      Write($"[{i}]\t");
   }
   WriteLine();
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      Write($"[{i}]\t");
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j]} \t");
      }
      WriteLine();
   }
}

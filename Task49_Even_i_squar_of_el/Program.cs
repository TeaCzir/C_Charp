/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.*/

using System;
using static System.Console;


Clear();

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
Clear();
WriteLine();
Write("Вы ввели ");
WriteLine($"количество строк: {rows};");
WriteLine($" и    количество столбцов: {columns};");
WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();

PrintArray(ChangeArray(array));

int[,] GetArray(int m, int n, int min, int max)
{
   int[,] result = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         result[i, j] = new Random().Next(min, max + 1);
      }

   }
   return result;
}

int[,] ChangeArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i % 2 == 0 && j % 2 == 0)
         {
            array[i, j] *= array[i, j];
         }
      }
   }
   return array;
}

// void PrintArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Write($"{array[i, j]} ");
//       }
//       WriteLine();
//    }
// }
void PrintArray(int[,] arrayToPrint)
{
   Console.Write($"[ ]\t");
   for (int i = 0; i < arrayToPrint.GetLength(1); i++)
   {
      Console.Write($"[{i}]\t");
   }
   Console.WriteLine();
   for (int i = 0; i < arrayToPrint.GetLength(0); i++)
   {
      Console.Write($"[{i}]\t");
      for (int j = 0; j < arrayToPrint.GetLength(1); j++)
      {
         Console.Write(arrayToPrint[i, j] + "\t");
      }
      Console.WriteLine();
   }
}
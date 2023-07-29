/*Задайте двумерный массив. Напишите программу, которая заменяет строки на 
столбцы. В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.*/

Console.Clear();
Console.WriteLine("Матрица изначальная:");
Console.WriteLine();
int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviatiot)
{
   int[,] rezult = new int[rowNumber, colNumber];
   for (int i = 0; i < rowNumber; i++)
   {
      for (int j = 0; j < colNumber; j++)
      {
         rezult[i, j] = new Random().Next(-deviatiot, deviatiot + 1);
      }
   }
   return rezult;
}

void Prent2DArray(int[,] arrayToPrint)
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

int[,] RowsToColumns(int[,] array)
{
   int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
   if (array.GetLength(0) != array.GetLength(1))
   {
      return matrix;
   }
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         matrix[i, j] = array[j, i];
      }
   }
   return matrix;
}

int[,] matrix = GetRandom2DArray(5, 3, 10);
Prent2DArray(matrix);
Console.WriteLine();
Console.WriteLine("Матрица повернутая строки в столбцы:");
Console.WriteLine();
int[,] matr = RowsToColumns(matrix);
Prent2DArray(matr);

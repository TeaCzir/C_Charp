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

void RowsToColumns(int[,] matrix)
{
   // int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
   if (matrix.GetLength(0) != matrix.GetLength(1))
   {
      Console.WriteLine("Матрица невозможна.");
   }
   else
   {
      Console.WriteLine("Матрица повернутая строки в столбцы:");
      Console.WriteLine();
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         for (int j = 0 + i; j < matrix.GetLength(1); j++)
         {
            int temp = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = temp;
         }

      }
      Prent2DArray(matrix);
   }

}

int[,] matrix = GetRandom2DArray(4, 4, 10);
Prent2DArray(matrix);
Console.WriteLine();

RowsToColumns(matrix);
Console.WriteLine();
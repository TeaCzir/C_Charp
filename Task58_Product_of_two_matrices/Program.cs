/* Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц*/

using static
System.Console;
Clear();

Write("Введите количество строк первого массива: ");
int rowsA = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов первого массива: ");
int columnsA = Convert.ToInt32(ReadLine());
Write("Введите количество строк второго массива: ");
int rowsB = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов второго массива: ");
int columnsB = Convert.ToInt32(ReadLine());
if (columnsA != rowsB)
{
   WriteLine("Невозможно умножить матрицы!");
   return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
WriteLine();
PrintArray(B);
WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));



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

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
   int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
   for (int i = 0; i < arrayA.GetLength(0); i++)
   {
      for (int j = 0; j < arrayB.GetLength(1); j++)
      {
         for (int k = 0; k < arrayA.GetLength(1); k++)
         {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
         }
      }
   }
   return arrayC;
}

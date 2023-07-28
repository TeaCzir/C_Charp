/*Задайте двухмерный массив. Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1,1); и т.д.*/

int[,] CreateAndFillMatrix(int rows, int columns, int start, int end)
{
   int[,] matrix = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         matrix[i, j] = new Random().Next(start, end + 1);
      }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
{
   Console.Write($"[ ]\t");
   for (int i = 0; i < matrix.GetLength(1); i++)
   {
      Console.Write($"[{i}]\t");
   }
   Console.WriteLine();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      Console.Write($"[{i}]\t");
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write(matrix[i, j] + "\t");
      }
      Console.WriteLine();
   }
}

int SumOfDiagonalElement(int[,] matrix)
{
int sumOfDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
      if(i==j) sumOfDiagonal += matrix[i,j];
   }
}
return sumOfDiagonal;
}

int[,] number = CreateAndFillMatrix(5,4,1,10);
PrintMatrix(number);

Console.WriteLine($"Сумма по главной диагонали: {SumOfDiagonalElement(number)};");






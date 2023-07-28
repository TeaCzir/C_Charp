/*Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.*/

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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
void PrintMatr(int[,] array)
{
   Console.WriteLine("Среднее арифметическое столбцов матрицы: ");
   Console.Write("[м]\t");
   for (int i = 0; i < array.GetLength(1); i++)
   {
      double result = 0;

      for (int j = 0; j < array.GetLength(0); j++)
      {
         result += array[j, i];
      }
      Console.Write(Math.Round(result / array.GetLength(0), 2) + "\t");
   }
}

int[,] number = CreateAndFillMatrix(rows, columns, 1, 10);
PrintMatrix(number);
PrintMatr(number);
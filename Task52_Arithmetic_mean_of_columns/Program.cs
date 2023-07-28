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

double[] ArithmeticMeanOfColumns(int[,] matrix)
{
   double[] aritcol = new double[matrix.GetLength(1)];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         aritcol[j] += matrix[i, j] / matrix.GetLength(0);
      }
   }

   return aritcol;
}

int[,] number = CreateAndFillMatrix(rows, columns, 1, 10);
PrintMatrix(number);
double[] num = ArithmeticMeanOfColumns(number);
// PrintMatrix(num);
//Console.WriteLine($"        {String.Join(";      ", num)};");
Console.WriteLine($"        {String.Join(";      ", num)};");
/* Показать двумерный массив размером m×n заполненный вещественными числами*/

Console.Clear();
int m = 5;
int n = 8;
int x = -100;
int y = 100;

double[,] array = new double[m, n];

void FillArray(double[,] arrayToPrint)
{
   for (int i = 0; i < arrayToPrint.GetLength(0); i++)
   {
      for (int j = 0; j < arrayToPrint.GetLength(1); j++)
      {
         arrayToPrint[i, j] = new Random().NextDouble() * ((y + 1) - x) + x;
      }
   }
}

void Print(double[,] arrayToPrint)
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
         Console.Write(Math.Round(arrayToPrint[i, j], 2) + "\t");
      }
      Console.WriteLine();
   }
}
FillArray(array);
Print(array);
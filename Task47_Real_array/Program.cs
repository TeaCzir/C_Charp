/*Задайте двумерный массив размером m×n, заполненный случайными вещественными 
числами.*/
Console.Clear();
double[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{   
   double[,] rezult = new double[rowNumber, colNumber];
   for (int i = 0; i < rowNumber; i++)
   {
      for (int j = 0; j < colNumber; j++)
      {
         rezult[i, j] = new Random().NextDouble() * ((deviation + 1) + deviation) - deviation;
      }
   }
   return rezult;
}

void Prent2DArray(double[,] arrayToPrint)
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
double[,] randomArray = GetRandom2DArray(5, 8, 10);
Prent2DArray(randomArray);

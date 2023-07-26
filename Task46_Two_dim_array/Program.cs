/*Задайте двумерный массив размером m×n, заполненный случайными целыми числами.*/
Console.Clear();

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
int[,] randomArray = GetRandom2DArray(5, 4, 10);
Prent2DArray(randomArray);

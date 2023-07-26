/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: A[i][j] = i + j. Выведите полученный массив на экран.*/
Console.Clear();

int[,] Get2DArray(int rowNumber, int colNumber)
{
   int[,] rezult = new int[rowNumber, colNumber];
   for (int i = 0; i < rowNumber; i++)
   {
      for (int j = 0; j < colNumber; j++)
      {
         rezult[i, j] = i + j;
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
int[,] Array = Get2DArray(5, 8);
Prent2DArray(Array);

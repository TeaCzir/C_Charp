/*Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строки.*/

// Console.Clear();

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

void Replace(int[,] array)
{
   int temp = 0;
   for (int i = 0; i < array.GetLength(1); i++)
   {
      temp = array[array.GetLength(0) - 1, i];
      array[array.GetLength(0) - 1, i] = array[0, i];
      array[0, i] = temp;     
   }
}
int[,] arrayRnd = GetRandom2DArray(4, 4, 10);
Prent2DArray(arrayRnd);
Console.WriteLine();
Replace(arrayRnd);
Prent2DArray(arrayRnd);
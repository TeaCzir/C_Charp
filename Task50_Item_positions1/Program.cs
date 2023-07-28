/*Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что 
такого элемента нет.*/

Console.Clear();

System.Console.WriteLine("Задан массив: ");

int[,] randomArray = GetRandom2DArray(8, 4, 10);
Print2DArray(randomArray);
Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows < 0 ||
rows >= randomArray.GetLength(0) ||
columns < 0 || columns >= randomArray.GetLength(1))
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
   Console.WriteLine("Такой позиции в массиве нет. ");
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Зараза. Я очень сожалею. ");
   Console.ResetColor();
}

else
System.Console.Write($"Позиция: [{rows}, {columns}]; ");
   Console.WriteLine($"Значение элемента: {randomArray[rows, columns]};");

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
void Print2DArray(int[,] arrayToPrint)
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

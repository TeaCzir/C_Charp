/*Задайте одномерный массив из 123 случайных чисел.
Найдите колличество элементов массива, значения которых лежат в 
отрезке [10, 99]*/
Console.Clear();
Console.WriteLine("Массив из 123 случайных чисел: ");

int fillNumberArray(int[] array, int start, int end)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] >= start && array[i] <= end)
      {
         count++;
      }
   }
   return count;
}

int[] getRandomArray(int length, int deviation)
{
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      result[i] = new Random().Next(0, deviation + 1);
   }
   return result;
}
void printArray(int[] arrayToPrint)
{
   Console.ForegroundColor = ConsoleColor.Green;
   Console.Write("[");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
      Console.Write(arrayToPrint[i]);
      if (i != arrayToPrint.Length - 1) Console.Write(", ");
   }
   Console.WriteLine("]");
   Console.WriteLine("======================================================================");
   Console.ForegroundColor = ConsoleColor.Magenta;
}

int[] myArray = getRandomArray(123, 100);
printArray(myArray);
int result = fillNumberArray(myArray, 10, 99);
Console.WriteLine($"Колличество двузначно-положительных чисел: {result},");
Console.WriteLine("которые находятся в промежутке от 10 до 99.");
Console.ForegroundColor = ConsoleColor.White;
/*Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицателных и положительных 
элементов массива 
*/
Console.Clear();
Console.WriteLine("Массив из 12 элементов от -9 до 9: ");

int[] getRandomArray(int length, int deviation)
{
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      result[i] = new Random().Next(-deviation, deviation + 1);
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
   Console.WriteLine("-------------------------------------------");
   Console.ForegroundColor = ConsoleColor.DarkBlue;
}
int sumElementOfArray(int[] arrayToCalculate, int multiply)
{
   int result = 0;
   for (int i = 0; i < arrayToCalculate.Length; i++)
   {
      if (arrayToCalculate[i] * multiply > 0)
      {
         result += arrayToCalculate[i];
      }

   }
   return result;
}
int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);
int positiveSumOfArray = sumElementOfArray(randomArray, 1);
int negativeSumOfArray = sumElementOfArray(randomArray, -1);
Console.WriteLine($"Сумма положительных чисел: {positiveSumOfArray}");
Console.WriteLine($"Сумма отрицательных чисел: {negativeSumOfArray}");
Console.ForegroundColor = ConsoleColor.White;
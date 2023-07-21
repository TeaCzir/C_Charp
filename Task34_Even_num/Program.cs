/*Задайте массив заполненный случайными положительными трехзначными 
числами. Напишите программу, которая покажет колличество четных 
чисел в массиве.*/
Console.Clear();
Console.WriteLine("Массив из случайных, трехзначных и положительных чисел: ");

int[] getRandomArray(int length, int ThreeDigit)
{
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      if (result[i] < 0)
      {
         result[i] *= -1;
      }
      result[i] = new Random().Next(100, 999);
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
   Console.ForegroundColor = ConsoleColor.DarkBlue;
}
int Even(int[] arrayToCalculate)
{
   int result = 0;
   for (int i = 0; i < arrayToCalculate.Length; i++)
   {
      if (arrayToCalculate[i] % 2 == 0)
      {
         result++;
      }

   }
   return result;
}
int[] randomArray = getRandomArray(14, 999);
printArray(randomArray);
int NumberOfEven = Even(randomArray);

Console.WriteLine($"Колличество четных чисел в массиве: {NumberOfEven}");

Console.ForegroundColor = ConsoleColor.White;





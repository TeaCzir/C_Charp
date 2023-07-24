/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.*/
Console.Clear();
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
   int sum = 0;
   Console.ForegroundColor = ConsoleColor.Green;
   Console.Write("[");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
      Console.Write(arrayToPrint[i]);
      if (i != arrayToPrint.Length - 1) Console.Write(", ");
      if (arrayToPrint[i] > 0)
         sum++;

   }
   Console.WriteLine("]");
   Console.WriteLine("-------------------------------------------");
   Console.ForegroundColor = ConsoleColor.Cyan;
   Console.Write("Колличество положительных чисел: ");
   Console.ForegroundColor = ConsoleColor.DarkMagenta;
   Console.WriteLine($" {sum};");
}


int[] arr = getRandomArray(14, 9);
printArray(arr);
Console.ForegroundColor = ConsoleColor.White;

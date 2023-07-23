/*Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечетных позициях.*/
Console.Clear();
int[] Array = getRandomArray(14, 10);
System.Console.WriteLine($"Массив из {Array.Length} элеметтов: ");
printArray(Array);
int SumArray = sumOfNumOddPosition(Array);

int[] getRandomArray(int length, int deviation)
{
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      result[i] = new Random().Next(-deviation, deviation + 1);
   }
   return result;
}
void printArray(int[] arr)
{
   Console.ForegroundColor = ConsoleColor.Green;
   Console.Write("[");
   for (int i = 0; i < arr.Length; i++)
   {
      Console.Write(arr[i]);
      if (i != arr.Length - 1) Console.Write(", ");
   }
   Console.WriteLine("]");
   Console.WriteLine("-------------------------------------------");
   Console.ForegroundColor = ConsoleColor.White;
}
int sumOfNumOddPosition(int[] arr)
{
int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
   sum = sum + arr[i];
}

Console.Write($"Сумма элементов с нечетным индексом равна: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{sum};");
return sum;
}
Console.ForegroundColor = ConsoleColor.White;
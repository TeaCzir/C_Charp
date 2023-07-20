/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/

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
   Console.ForegroundColor = ConsoleColor.Cyan;
}
Console.Write("   Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"   Вы ввели число: {a};");
Console.Write("Массив: ");
int[] arr = getRandomArray(8, 9);
printArray(arr);
bool Num(int[] arr, int number)
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] == number)
         return true;
   }
   return false;
}
if (Num(arr, a)) Console.WriteLine("Да. Такое число присутствует в массиве.");
else Console.WriteLine("Нет. Такого числа в массиве нет.");
Console.ForegroundColor = ConsoleColor.White;
/*Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/
Console.Clear();

int[] CopyArray(int[] Arr)
{
   int[] copyringarray = new int[Arr.Length];
   for (int i = 0; i < Arr.Length; i++)
   {
      copyringarray[i] = Arr[i];
   }
   return copyringarray;
}

int[] test = { 1, 8, 5, 9, 2, 4, 7 };

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
}
printArray(test);
int[] CArr = CopyArray(test);
printArray(CArr);
Console.ForegroundColor = ConsoleColor.White;

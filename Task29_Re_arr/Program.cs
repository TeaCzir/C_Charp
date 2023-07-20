/* Разворот массива в обратном порядке.*/
Console.Clear();
Console.Write("  Массив: ");

void PrintArray(int[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]);
      if (i < array.Length - 1) Console.Write(", ");
      if (i == array.Length - 1) Console.Write("");
   }
   Console.Write("]");
   Console.WriteLine();
   Console.Write("Разворот: ");
   Console.Write("[");
   for (int i = array.Length - 1; i >= 0; i--)
   {
      Console.Write(array[i]);
      if (i >= 1) Console.Write(", ");
      if (i == 0) Console.Write("");
   }
   Console.Write("]");
}
int[] array = new int[8];
for (uint i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(10, 99);
}
PrintArray(array);

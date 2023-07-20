/*Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.*/
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
}
int[] array = new int[8];
for (uint i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(0, 2);
}
PrintArray(array);

/*Напишите программу замена элементов мвссива: положительные элементы 
замените на соответствующие отрицательные, и напоборот.*/

Console.Clear();
Console.WriteLine("Массив до замены: ");

int[] Array(int length, int deviation)
{
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      result[i] = new Random().Next(-deviation, deviation + 1);
   }
   return result;
}

void PrintArray(int[] farray)
{
   Console.Write("[");
   for (int i = 0; i < farray.Length; i++)
   {
      Console.Write(farray[i]);
      if (i != farray.Length - 1) Console.Write(", ");
   }
   Console.WriteLine("]");
}
int[] Rarray = Array(14, 21);
PrintArray(Rarray);
void Replacement(int[] num)
{
   for (int i = 0; i < num.Length; i++)
   {
      num[i] *= -1;
   }
}
Console.WriteLine("Массив после замены: ");
Replacement(Rarray);
PrintArray(Rarray);

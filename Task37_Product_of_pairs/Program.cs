/*Найдите произведение пар чиселв одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпослендний и т. д. Результат выводим в 
новом массиве.*/

System.Console.Clear();
int[] array = getRandomArray(14, 9);
Console.WriteLine($"Массив из {array.Length} случайных элементов: ");
printArray(array);
if (array.Length % 2 == 0)
{
   Console.WriteLine("Результаты произведения пар из четного массива: ");
    int[] prodArray = productOfPairs(array);
   printArray(prodArray);
}

if (array.Length % 2 == 1)
{
   Console.WriteLine("Результаты произведения пар из нечетного массива: ");
   int[] prodArray = productOfPairs1(array);
   printArray(prodArray);
}
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
   Console.WriteLine("======================================");
   Console.ForegroundColor = ConsoleColor.Cyan;
}

int[] productOfPairs(int[] arr)
{
   int size = arr.Length / 2;

   int[] productArr = new int[size];

   if (arr.Length % 2 == 0)
   {

      for (int i = 0; i < size; i++)
      {
         productArr[i] = arr[i] * arr[arr.Length - 1 - i];
      }

   }
   return productArr;
}
int[] productOfPairs1(int[] arr)
{
   int size1 = arr.Length / 2 + 1;
   int[] productArr1 = new int[size1];
   if (arr.Length % 2 == 1)
   {

      for (int i = 0; i < size1; i++)
      {
         productArr1[i] = arr[i] * arr[arr.Length - 1 - i];
      }
      productArr1[size1 - 1] = arr[arr.Length / 2];

   }
   return productArr1;
}
Console.ForegroundColor = ConsoleColor.White;

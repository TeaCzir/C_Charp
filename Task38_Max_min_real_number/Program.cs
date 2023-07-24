/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементами массива.*/
Console.Clear();
Console.WriteLine("Массив вещественных чисел: ");

double[] RandomArr(int Length, int start, int fin)
{
   double[] RandArr = new double[Length];
   Random R = new Random();
   for (int i = 0; i < RandArr.Length; i++)
   {
      RandArr[i] = R.NextDouble() * (fin - start);
   }
   return RandArr;
}
void printArray(double[] arr)
{

   Console.Write("[");

   for (int i = 0; i < arr.Length; i++)
   {
      Console.Write($"{arr[i]:f2}");
      if (i != arr.Length - 1) Console.Write("; ");
   }
   Console.WriteLine("];");
}
double diffMaxMin(double[] Array)
{
   double Max = Array[0];
   double Min = Array[0];

   for (int i = 0; i < Array.Length; i++)
   {
      if (Array[i] > Max) Max = Array[i];
      if (Array[i] < Min) Min = Array[i];
   }
   return (Max - Min);
}


double[] Arry = RandomArr(7, 10, 100);
double Diff = diffMaxMin(Arry);
printArray(Arry);
Console.WriteLine($"Разница максимального и минимального элементов: {Diff:f2};");


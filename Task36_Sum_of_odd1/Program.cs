/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
Console.Clear();
int[] array = CreateRandomarray();
ShowArray(array);
int sum = SumOfOddIndexElements(array);
Console.Write($"Сумма элементов на нечетных позициях: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"{sum};");
Console.ForegroundColor = ConsoleColor.White;
void ShowArray(int[] array)
{
    Console.Write("Элементы массива: ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;
}

int[] CreateRandomarray()
{
    int minSizeArray = 0;
    int maxSizeArray = 100;
    Random rnd = new Random();
    int[] rndArr = new int[14];
    for (int i = 0; i < rndArr.Length; i++)
    {
        rndArr[i] = rnd.Next(minSizeArray, maxSizeArray);
    }
    return rndArr;
}

int SumOfOddIndexElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) //i=i+2
    {
        sum = sum + array[i];
    }
    return sum;
}
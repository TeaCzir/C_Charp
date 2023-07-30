/*Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.*/

Console.Clear();

Console.WriteLine("Задан массив:");

int[,] GetRandom2dArray(int rows, int columns, int deviation)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] FindSumOfNumber(int[,] array)
{
    int[] sumInArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInArray[i] += array[i, j];
        }
    }
    return sumInArray;
}

int  MinSumInArray(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= array[min])
        {
            min = i;
        } 
    }return min;
}


int[,] matrix = GetRandom2dArray(8, 4, 10);
Print2DArray(matrix);

int[] newArray = FindSumOfNumber(matrix);
Console.WriteLine();
int result = MinSumInArray(newArray);
Console.WriteLine($"Строка с наименьшей суммой чисел: {result+1};");
Console.WriteLine();
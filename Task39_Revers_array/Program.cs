/*Напишите программу, которая перевернет одномерный массив. 
(последний элемент будет на первом месте, а первый на последнем.)
*/
Console.Clear();
int[] creatingArrey(int Length, int start, int end)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void printArray(int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] inverted(int[] array)
{
    int[] final = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    final[i] = array[array.Length-1-i];
}
return final;
}

int[] num = creatingArrey(10, -100, 100);
printArray(num, "Полученный массив: ");
int[] invArray = inverted(num);
printArray(invArray, "Перевернутый в обратном порядке массив: ");

/*Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что 
такого элемента нет.*/
Console.Clear();
Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
// while (rows >= 0 || rows <= 7 && columns >= 0 || columns <= 7)



// Console.Write($"Значение элемента: {Array2D[rows, columns]};");

// else   Console.WriteLine("Такого элемента в массиве нет:");

// Console.Write("Введите номер столбца: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// while (columns < 0 || columns > 4)
// {
//    Console.WriteLine("Такого элемента в массиве нет:");
//    break;
// }
Console.Clear();
Console.WriteLine();
Console.Write("Вы ввели ");
Console.WriteLine($"номер строки: {rows};");
Console.WriteLine($" и    номер столбца: {columns};");
Console.WriteLine();

while (rows < 0 || rows > 7 || columns < 0 || columns > 7)
{

   Console.Clear();
   Console.Write("Вы ввели ");
   Console.WriteLine($"номер строки: {rows};");
   Console.WriteLine($" и    номер столбца: {columns};");
   Console.Write("Такой позиции в массиве нет. ");
   Console.Write("Введите номер строки от 0 до 3: ");
   rows = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите номер столбца от 0 до 7: ");
   columns = Convert.ToInt32(Console.ReadLine());
}


int[,] Array2D = new int[4, 8]
{
{5, 8, 3, 7, 4, 1, 9, 5},
{4, 2, 9, 7, 2, 5, 8, 3},
{2, 5, 8, 9, 3, 5, 4, 8},
{8, 5, 9, 7, 2, 4, 9, 3},
};
// Console.Write($"Значение элемента: {Array2D[rows, columns]};");
if (rows >= 0 || rows <= 7 && columns >= 0 || columns <= 7)
   Console.Write($"Значение элемента: {Array2D[rows, columns]};");
// Console.WriteLine("Такого элемента в массиве нет:");
else Console.WriteLine("Такого элемента в массиве нет:");
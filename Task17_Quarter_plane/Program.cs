/*Напишите программу, которая принимает на вход кординаты 
точки и выдает номер четверти плоскости, в которой находится 
эта точка.*/
Console.Clear();
int Quarter(int X, int Y)
{
   int result = 0;
   if (X > 0 && Y > 0) result = 1;
   else if (X < 0 && Y > 0) result = 2;
   else if (X < 0 && Y < 0) result = 3;
   else if (X > 0 && Y < 0) result = 4;
   return result;
}

Console.Write("Введите горизонтальную кординату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вертикальную кординату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели координаты точки: ({X}, {Y});");

int plane = Quarter( X, Y);
if(plane > 0)
Console.WriteLine($"Точка ({X}, {Y}) находится в {plane} плоскости;");
else
Console.WriteLine($"Точка ({X}, {Y}) находится на пересечении плоскостей;");

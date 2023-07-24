/*Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.*/
Console.Clear();
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {value};");
int binary =0; //Convert.ToInt32(Console.ReadLine());;
int shift = 1;
while (value != 0)
{
   binary += value % 2 *shift;
   shift *=10;
   value/=2;
}
Console.Write($"Оно в двоичном исчеслении будет выглядеть так: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write($"{binary};");
Console.ForegroundColor = ConsoleColor.White;

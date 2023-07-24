/*Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.*/
Console.Clear();
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {value};");

double DecImalToBinary(int dec)
{
double bin = 0;
int count = 0;
while (dec > 0)
{
   bin+=dec%2* Math.Pow(10, count);
   dec /= 2;
   count++;
}
return bin;
}

Console.Write($"Оно в двоичном исчеслении будет выглядеть так: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(DecImalToBinary(value));
Console.ForegroundColor = ConsoleColor.White;






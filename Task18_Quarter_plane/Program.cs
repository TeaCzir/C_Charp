/*Напишите программу, по заданному номеру четверти, показывает 
дапазон возможных координат точек в четверти(x и y).*/
Console.Clear();
string Quarter(int quar)
{
   if (quar == 1) return "Координаты точки: X > 0; Y > 0;";
   else if (quar == 2) return "Координаты точки: X < 0; Y > 0;";
   else if (quar == 3) return "Координаты точки: X < 0; Y < 0;";
   else if (quar == 4) return "Координаты точки: X > 0; Y < 0;";
   else return "Недопустимый номер четверти.";
}

Console.Write("Введите номер четверти: ");
int Q = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели номер четверти: {Q};");
Console.WriteLine(Quarter(Q));

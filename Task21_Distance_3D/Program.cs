/* Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве
*/

Console.Clear();
Console.Write("Введите x1 ");
double x1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y1 ");
double y1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите z1 ");
double z1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите x2 ");
double x2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y2 ");
double y2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите z2 ");
double z2 = Convert.ToInt64(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели: точка A ({x1}, {y1}, {z1}) и точка B ({x2}, {y2}, {z1});");

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.Write($"Расстояние от точки А до точки В равно: {d:f2};");

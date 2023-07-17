/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве.*/

Console.Clear();
Console.Write("Введите x1 ");
double x1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y1 ");
double y1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите x2 ");
double x2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y2 ");
double y2 = Convert.ToInt64(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели: точка A ({x1}, {y1}) и точка B ({x2}, {y2}),");
// double d1 = Math.Sqrt(-4);

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"Расстояние от А до В равно {d:f2}.");

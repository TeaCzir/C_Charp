/*Напишите программу, которая принимает на вход три числа, 
и проверят может ли существовать треугольник со сторонами такой длинны.*/
Console.Clear();
Console.Write("Введите первое число: ");
int sid1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int sid2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int sid3 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели три числа: ({sid1}, {sid2}, {sid3});");
bool sides(int sid1, int sid2, int sid3)
{
    if (sid1 + sid2 > sid3
    && sid2 + sid3 > sid1
    && sid3 + sid1 > sid2)
        return true;
    return false;
}
if (sides(sid1, sid2, sid3))
    Console.WriteLine("Треуголник с такими сторонами возможен.");
else
    Console.WriteLine("Треуголник с такими сторонами невозможен.");

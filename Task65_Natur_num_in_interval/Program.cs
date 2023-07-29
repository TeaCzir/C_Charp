/*Задайте значения M и N. Напишите программу, которая выдает все натуральные числа 
от M до N.*/

Console.Clear();

void RecursionNumberMN(int start, int finish)
{
   if (start <= finish)
   {
      Console.Write(start + ", ");
      RecursionNumberMN(start + 1, finish);
  }
}
RecursionNumberMN(1, 8);


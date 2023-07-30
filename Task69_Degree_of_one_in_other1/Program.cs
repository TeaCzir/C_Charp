/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в натуральную степень B с помощью рекурсии.*/


int AToRowB(int a, int b)
{
   if (b == 1)
   {
      return a;
   }
   else
   {
      return a * AToRowB(a, b - 1);
   }

}



Console.WriteLine(AToRowB(8, 4));

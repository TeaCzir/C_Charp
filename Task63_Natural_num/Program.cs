/* Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.*/

void NatureLeNum(int Number, int count = 1)
{
   if (Number < count)
   {
      return;
   }
   else
   {
      Console.Write(count + ", ");
      NatureLeNum(Number, count + 1);
   }
}
NatureLeNum(14);

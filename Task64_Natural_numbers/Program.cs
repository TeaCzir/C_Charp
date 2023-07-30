/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1.*/

Console.Clear();
int numbers = NumInp("Введите N: ");
int count = 2;
PrintNum(numbers, count);
Console.Write(1);

void PrintNum(int numbers, int count)
{
  if (count > numbers) return;
  PrintNum(numbers, count + 1);
  Console.Write(count + ", ");
}

int NumInp(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

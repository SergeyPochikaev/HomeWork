//Задача4:  Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.Clear();
int xa = 0, ya = 1;
Console.WriteLine("Условие: Водятся только целые числа ");
Console.WriteLine("-----------------------------------------------");

Console.Write("Введите значение a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b == max)
{
  if (c == max) Console.WriteLine("Значения все равны!");
  else
  {
    if (c > max) max = c;
  Console.Write("max = ");
  Console.WriteLine(max);
  }
}
else
{
  if (b > max) max = b;
  if (c > max) max = c;
  Console.Write("max = ");
  Console.WriteLine(max);
}
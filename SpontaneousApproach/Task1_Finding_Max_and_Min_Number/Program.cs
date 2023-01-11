//Задача2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

Console.Clear();
int xa = 0, ya = 1;
Console.WriteLine("Условие: Водятся только целые числа ");
Console.SetCursorPosition(xa, ya);
Console.WriteLine("-----------------------------------------------");

Console.Write("Введите значение a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
  Console.WriteLine("Значение <<a>> равна = значению <<b>>!");
}
else
{
  if (a > b)
  {
    Console.Write("Значение <<a>> является наибольшей и равна = ");
    Console.WriteLine(a);
    Console.Write("Значение <<b>> является наименьшей и равна = ");
    Console.WriteLine(b);
  }
  else
  {
    Console.Write("Значение <<a>> является наименьшей и равна = ");
    Console.WriteLine(a);
    Console.Write("Значение <<b>> является наибольшей и равна = ");
    Console.WriteLine(b);
  }
}
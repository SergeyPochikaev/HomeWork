//Задача 10: Напишите программу, которая принимает на вход трёхзначное число,
//и на выходе показывает вторую цифру этого числа..

Console.Clear();
Console.WriteLine("Условие: Вводите только любые целые трехзначные числа");
int xa = 0, ya = 1;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("-----------------------------------------------");

Console.Write("Введите трехзначное число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (N < 100)
{
  while (N < 100)
  {
    Console.Write("Вы ошиблись, читайте внимательно условие!!!\nВедите заново целое трехзначное число N = ");
    N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (N >= 1000)
    {
      while (N >= 1000)
      {
        Console.Write("Вы ошиблись, читайте внимательно условие!!!\nВедите заново целое трехзначное число N = ");
        N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
      }
    }
  }
}
else
{
  if (N >= 1000)
  {
    while (N >= 1000)
    {
      Console.Write("Вы ошиблись, читайте внимательно условие!!!\nВедите заново целое трехзначное число N = ");
      N = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      if (N < 100)
      {
        while (N < 100)
        {
          Console.Write("Вы ошиблись, читайте внимательно условие!!!\nВедите заново целое трехзначное число N = ");
          N = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();
        }
      }
    }
  }
}
int num2 = N % 100;
if (num2 > 10) num2 = num2 / 10;
else
{
  if (num2 > 0 && num2 < 10)
  {
    num2 = num2 / 10;
    num2 = num2 % 10;
  }
}
Console.Write($"Вторая цифра из числа N = {N} является: {num2}");
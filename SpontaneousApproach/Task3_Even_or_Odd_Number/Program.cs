//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным.

Console.Clear();
Console.WriteLine("Условие: Вводите только любое целое число");
int xa = 0, ya = 1;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("-----------------------------------------------");

Console.Write("Введите значение a = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine("Число <<a>> является четным!");
else
  Console.WriteLine("Число <<a>> является нечетным!");

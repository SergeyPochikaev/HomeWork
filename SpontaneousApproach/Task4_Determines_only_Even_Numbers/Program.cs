//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Условие: Вводите только любое целое число");
int xa = 0, ya = 1;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("-----------------------------------------------");

Console.Write("Введите кол-во случайных чисел N = ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int count = 0;
// Запись массива случайными числами и его вывод:
while (count < N)
{
  array[count] = new Random().Next(0, N + 1);
  Console.Write(" ");
  System.Console.Write(array[count]);
  count = count + 1;
}
// Вывод отсортированных случайных чисел:
count = 0;
Console.WriteLine("");
Console.WriteLine("Отсортированы следующие четные числа: ");
while (count < N)
{
  if (array[count] % 2 == 0)
  {
    Console.Write(" ");
    Console.Write(array[count]);
  }
  count++;
}

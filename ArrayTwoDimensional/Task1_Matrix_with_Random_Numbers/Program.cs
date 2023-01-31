// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

// Метод задания N элементов для массива
int GetNumbersByUser(string text)
{
  Console.Clear();
  Console.Write($"Введите количество элементов в массиве length = {text}");
  return Convert.ToInt32(Console.ReadLine());
}

// Метод создания массива случайным образом
int[] CreateArrayNumbers(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
  return array;
}

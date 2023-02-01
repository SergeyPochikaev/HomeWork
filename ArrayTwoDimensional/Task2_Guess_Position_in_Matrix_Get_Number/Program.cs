// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Метод - Большая игра
void InputCondition()
{
  Console.Clear();
  Console.WriteLine("---------------------------------------------------");
  Console.WriteLine("Сыграем в большую игру!!!\nУгадай позицию в матрице и получи счастливое число!");
  Console.WriteLine("---------------------------------------------------");
  Console.WriteLine("Ведите номер позиции [i,j] элемента в 2-х массиве\nпоследовательно через Enter кратную 10:");
}

// Методом кортежа задается случайный размер матрицы m*n
(int length, int width) GetSizeMatrix()
{
  int length = Random.Shared.Next(2, 11);
  int width = Random.Shared.Next(2, 11);
  return (length, width);
}

// Метод создания матрицы случайным образом
int[,] GetMatrixRandom(int length, int width)
{
  int[,] matrix = new int[length, width];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Random.Shared.Next(1, 10);
    }
  }
  return matrix;
}

// Метод ввода позиции элемента в матрице от Пользователя
int[] GetPositionOfUser()
{
  int[] array = new int[2];
  Console.Write("Веди номер строки i = ");
  array[0] = Convert.ToInt32(Console.ReadLine());
  Console.Write("Веди номер столбца j = ");
  array[1] = Convert.ToInt32(Console.ReadLine());
  return array;
}

// Метод сравнения позиций элементов между Пользователем и созданной матрице
int ComparisonOfPositions(int[,] matr, int[] array)
{
  int value = 0;
  if (array[0] < matr.GetLength(0) && array[1] < matr.GetLength(1))
  {
    value = matr[array[0], array[1]];
  }
  return value;
}

// Метод распечатки матрицы
void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]}|");
    }
    Console.WriteLine();
  }
}

string GoodPrint(int[] arrayInt, int count)
{
  return $"Вы выиграли, набрав позицию {String.Join(",", arrayInt)} -> {count} - это ваше Счастливое Число!";
}

InputCondition();
int[,] number = GetMatrixRandom(GetSizeMatrix().length, GetSizeMatrix().width);
int[] arrayUser = GetPositionOfUser();
PrintArray(number);
int result = ComparisonOfPositions(number, arrayUser);
if (result == 0)
{
  Console.WriteLine("Такого элемента в массиве нет");
}
else Console.WriteLine(GoodPrint(arrayUser, result));
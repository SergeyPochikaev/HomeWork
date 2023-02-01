// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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
      matrix[i, j] = Random.Shared.Next(1,10);
    }
  }
  return matrix;
}
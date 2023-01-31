// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

// Методом кортежа задается случайный размер матрицы m*n
(int length, int width) GetSizeMatrix()
{
  int length = Random.Shared.Next(2, 10);
  int width = Random.Shared.Next(2, 10);
  return (length, width);
}

// Метод создания матрицы случайным образом
double[,] GetMatrixRandom(int length, int width)
{
  double[,] matrix = new double[length, width];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Random.Shared.Next(-9, 10) / 1.5;
    }
  }
  return matrix;
}

// Метод распечатки матрицы
void PrintArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{Convert.ToDecimal(Math.Round(matr[i, j], 1))}|");
    }
    Console.WriteLine();
  }
}

double[,] number = GetMatrixRandom(GetSizeMatrix().length, GetSizeMatrix().width);
PrintArray(number);
// Задача 56. Задайте  прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой
// элементов.

// Методом кортежа задается случайный размер матрицы m*m
int  GetSizeMatrix()
{
  int length = Random.Shared.Next(2, 10);
  return length;
}

// Метод создания матрицы случайным образом
double[,] GetMatrixRandom(int length)
{
  double[,] matrix = new double[length, length];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Random.Shared.Next(0, 10);
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
      Console.Write($"{Math.Round(matr[i, j], 1)}|");
    }
    Console.WriteLine();
  }
}
int size = GetSizeMatrix();
double[,] number = GetMatrixRandom(size);
PrintArray(number);
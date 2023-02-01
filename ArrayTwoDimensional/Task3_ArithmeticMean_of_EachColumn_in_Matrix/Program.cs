// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Методом кортежа задается случайный размер матрицы m*n
(int length, int width) GetSizeMatrix()
{
  int length = Random.Shared.Next(2, 5);
  int width = Random.Shared.Next(2, 5);
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

// Метод определения среднеарифметическое значение по каждому столбцу
double[] GetArithmeticMean(int[,] matrix)
{
  double[] arithmeticMean = new double[matrix.GetLength(1)];
  double sum = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum = sum + matrix[i, j];
    }
    arithmeticMean[j] = Math.Round(sum / matrix.GetLength(0),1);
  }
  return arithmeticMean;
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

string GoodPrint(double[] arrayInt)
{
  return $"{String.Join(";", arrayInt)} - Среднее арифметическое каждого столбца";
}

int[,] number = GetMatrixRandom(GetSizeMatrix().length, GetSizeMatrix().width);
double[] arithMean = GetArithmeticMean(number);
PrintArray(number);
Console.WriteLine(GoodPrint(arithMean));
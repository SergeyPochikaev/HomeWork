// Задача 56. Задайте  прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой
// элементов.

// Методом кортежа задается случайный размер матрицы m*m
int GetSizeMatrix()
{
  int length = Random.Shared.Next(2, 5);
  return length;
}

// Метод создания матрицы случайным образом
int[,] GetMatrixRandomAndArray(int length)
{
  int[,] matrix = new int[length, length];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Random.Shared.Next(0, 10);
    }
  }
  return matrix;
}

// Метод определения суммы значение элементов по каждой строке
int[] GetSumRow(int[,] matrix)
{
  int[] sumRow = new int[matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      sum = sum + matrix[i, j];
    }
    sumRow[i] = sum;
  }
  return sumRow;
}

// Метод определения строки из массива с наименьшей суммой
void MinSumRow(int[] array)
{
  int min = array[0];
  int rowMin = 0;
  string res = String.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] <= min)
    {
      min = array[i];
      rowMin = i;
      //rowMin = i + 1;
      //res = res + $"{rowMin} ";
    }
  }
  res = $"{(rowMin + 1),2}";
  Console.Write(res + " - Номер строки c наименьшим значением");
}

// Метод распечатки матрицы
void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j],2}|");
    }
    Console.WriteLine();
  }
}
string GoodPrint(int[] arrayInt)
{
  return $"{String.Join(";", arrayInt)} - Сумма каждой строки";
}

int size = GetSizeMatrix();
int[,] getMatrix = GetMatrixRandomAndArray(size);
int[] getSumRow = GetSumRow(getMatrix);
PrintArray(getMatrix);
Console.WriteLine(GoodPrint(getSumRow));
MinSumRow(getSumRow);
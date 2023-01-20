//Задача 23: Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

// Метод считать от пользователя N
int GetNumberByUser(string text)
{
  Console.Clear();
  Console.Write($"Введите целое число N = {text}");
  return Convert.ToInt32(Console.ReadLine());
}

// Метод создания массива
int[] CreateArray(int size)
{
  return new int[size+1];
}

// Метод получения кубов чисел
void GetCubes(int[] colNumbers)
{
  int count = colNumbers.Length;
  for (int i = 1; i < count; i++)
  {
    colNumbers[i] = Convert.ToInt32(Math.Pow(i, 3));
  }
}

// Метод по распечатки результата
string Print(int[] numbers)
{
  string output = String.Empty;
  int size = numbers.Length;
  for (int i = 1; i < size; i++)
  {
    output = output + $"{i}^3 = {numbers[i]}\n";
  }
  return output;
}

int countByUser = GetNumberByUser("");
int[] list = CreateArray(countByUser);
GetCubes(list);
Console.WriteLine(Print(list));
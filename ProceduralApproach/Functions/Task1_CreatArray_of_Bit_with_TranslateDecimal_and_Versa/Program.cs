//Задача 777: Напишите программу, которая выводит массив из N элементов,
//заполненный нулями и единицами в случайном порядке, где реализовать
//перевод двоичного числа в десятичное.

// Метод задания N элементов пользователя
int GetNumberByUser(string text)
{
  //Console.Clear();
  Console.Write($"Введите целое число N = {text}");
  return Convert.ToInt32(Console.ReadLine());
}

// Метод создания массива
int[] CreateArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 2);
    array[0] = 1;
  }
  return array;
}

// Вывод отсортированных случайных чисел:
int ConvertArrayBitOnVersa(int[] array)
{

}
// count = 0;
// Console.WriteLine("");
// Console.WriteLine("Отсортированы следующие четные числа: ");
// while (count < N)
// {
//   if (array[count] % 2 == 0)
//   {
//     Console.Write(" ");
//     Console.Write(array[count]);
//   }
//   count++;
// }

// Метод по распечатки результата
string Print(int[] numbers)
{
  string output = String.Empty;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    output = output + String.Join(" ", $"{numbers[i]} ");
  }
  return output;
}

int n = GetNumberByUser("");
Console.WriteLine(Print(CreateArray(n)));

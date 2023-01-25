//Задача 777: Напишите программу, которая выводит массив из N элементов,
//заполненный нулями и единицами в случайном порядке, но с 1-м элементом массива равным значением 1,
//а также реализовать перевод двоичного числа (созданного массива) в десятичное.

// Метод задания N элементов для двоичного массива
int GetNumberByUser(string text)
{
  Console.Clear();
  Console.Write($"Введите разряд двоичного числа N = {text}");
  return Convert.ToInt32(Console.ReadLine());
}

// Метод создания двоичного массива с первым значением элемента равной 1
int[] CreateArrayBin(int size)
{
  int[] array = new int[size];
  for (int i = 1; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 2);
  }
  array[0] = 1;
  return array;
}

// Конвертация массива из 2-ого в 10-ое:
int ConvertArrayBitOnDecimal(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    sum += array[i] * Convert.ToInt32(Math.Pow(2, array.Length - i - 1));
  }
  return sum;
}

//Печать 2-ого числа и конвертированного 10-ое число
string GoodPrint(int[] bin, int dec)
{
  return $"{String.Join(" ", bin)} >> {dec}";
}

string Print(int[] bin)
{
  return $"{String.Join(" ", bin)}";
}

int n = GetNumberByUser("");
int[] bin = CreateArrayBin(n);
int dec = ConvertArrayBitOnDecimal(bin);
Console.WriteLine(GoodPrint(bin, dec));
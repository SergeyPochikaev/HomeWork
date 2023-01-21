//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.

// Метод ввода числа
int GetNumberByUser(string text)
{
  Console.Clear();
  Console.Write($"Введите целое положительное число N = {text}");
  return Convert.ToInt32(Console.ReadLine());
}

// Определение разряда из набранного числа n
int DigitNumber(int number)
{
  int k = 0;
  while (number > 0)
  {
    number = number / 10;
    k++;
  }
  return k;
}

//Создания массива из цифр по каждому разряду из заданного числа
int[] CreateArrayOfNumber(int size, int num)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    int chr = num / Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
    chr = chr % 10;
    array[i] = chr;
  }
  return array;
}

//Определения суммы всех элементов массива
int SumArrayElements(int[] arrNum)
{
  int sum = 0;
  for (int i = 0; i < arrNum.Length; i++)
  {
    sum += arrNum[i];
  }
  return sum;
}

//Печать массива
string GoodPrint(int[] numbers, int amount)
{
  return $"{String.Join(" ", numbers)} -> {amount} -- сумма из цифр в числе";
}

int n = GetNumberByUser("");
int dig = DigitNumber(n);
int[] arrNum = CreateArrayOfNumber(dig, n);
int sum = SumArrayElements(arrNum);
Console.WriteLine(GoodPrint(arrNum, sum));
// Задача 66. Задайте значения M и N. Напишите программу, которая  
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// Метод ввода 
int GetValueNumber(string text)
{
  Console.Write($"Ведите натуральное значение {text} = ");
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

//Метод вывода суммы натуральных элементов в промежутке от M до N либо от N до M
int SumElementsRec(int m, int n)
{
  // if (m <= n) return SumElementsRec(m, n - 1) + n;
  // else if (m > n) return SumElementsRec(m - 1, n) + m;
  // else return 0;
  if (m >= n) return SumElementsRec(m - 1, n) + m;
  else return 0;
}
int UnSumElementsRec(int m, int n)
{
  if (m <= n) return UnSumElementsRec(m, n - 1) + n;
  else return 0;
}

// Метод определения рекурсии при задании в другом порядке чисел 
int Check(int m, int n)
{
  if (m >= n) return SumElementsRec(m, n);
  else return UnSumElementsRec(m, n);
}

int m = GetValueNumber("M");
int n = GetValueNumber("N");
Console.WriteLine($"m = {m}; n = {n} -> {Check(m, n)}");
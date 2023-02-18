// Задача 68. Напишите программу вычисления функции Аккермана  
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Метод вода 
int GetValueNumber(string text)
{
  Console.Write($"Ведите натуральное значение {text} = ");
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

// Метод вычисления функции Аккермана
double A(double m, double n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

int m = GetValueNumber("m");
int n = GetValueNumber("n");
Console.WriteLine(A(m, n));
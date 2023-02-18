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
double Ack(double m, double n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

double m = GetValueNumber("m");
double n = GetValueNumber("n");
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ack(m, n)}");
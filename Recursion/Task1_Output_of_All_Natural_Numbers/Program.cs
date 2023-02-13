// Задача 64.  Задайте значение N. Напишите программу, которая  
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// Метод вода 
int GetValueNumber()
{
  Console.Write($"Ведите натуральное значение N = ");
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

// Метод вывода всех натуральных чисел
string OutputNatural(int n)
{

  if (n < 1) return String.Empty;
  else return $"{n}, " + OutputNatural(n - 1);
}

int n = GetValueNumber();
Console.WriteLine($"N = {n} -> " + OutputNatural(n));

// Задача 66. Задайте значения M и N. Напишите программу, которая  
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// Метод вода 
int GetValueNumber(string text)
{
  Console.Write($"Ведите натуральное значение {text} = ");
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}
// Метод вывода суммы натуральных элементов в промежутке от M до N
int SumElementsRec(int m, int n)
{
  if (m >= n) return SumElementsRec(m - 1, n) + m;
  else return 0;
  if (m <= n) return SumElementsRec(m, n - 1) + n;
  else return 0;

}
//int m = GetValueNumber("M");
//int n = GetValueNumber("N"); SumElementsRec(m, n - 1) + n;

Console.WriteLine(SumElementsRec(4, 8));

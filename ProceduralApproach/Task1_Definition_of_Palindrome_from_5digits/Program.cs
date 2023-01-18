//Задача 19: Напишите программу, которая принимает на вход пятизначное число
//и на выходе проверяет, является ли оно палиндромом.

// Метод - Условие ввода числа
void InputCondition()
{
  Console.Clear();
  Console.WriteLine("Условие: Введите любое целое число");
  Console.WriteLine("----------------------------------");
  Console.Write("Ведите число n = ");
}

// Метод - Определение палиндрома
bool CheckOnPalindrome(long value)
{
  long n = value;
  long inverseValue = 0;
  while (n > 0)
  {
    long remains = n % 10;
    inverseValue = inverseValue * 10 + remains;
    n = n / 10;
  }
  return value == inverseValue;
}

InputCondition();
long n = Convert.ToInt64(Console.ReadLine());
if (CheckOnPalindrome(n)) Console.WriteLine($"Число n = {n} является палиндромом");
else Console.WriteLine($"Число n = {n} не является палиндромом");
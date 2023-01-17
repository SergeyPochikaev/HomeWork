//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Условие: Вводите только любые целые числа");
int xa = 0, ya = 1;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("-----------------------------------------");

Console.Write("Ведите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

// Определение разряда из набранного числа 
int i = 0;
int Num = N;
while (N > 0)
{
  N = N / 10;
  i++;
}
// Условия вывода разряда (разряд считается с обратной стороны - ввод цифры)
Console.Write("Ведите цифру (обратный разряд) от заданного числа Chr = ");
int j = Convert.ToInt32(Console.ReadLine());
int chr = j;

if (i == j)
{
  chr = Num % 10;
  Console.WriteLine($"Число N = {Num} имеет {chr} разряд");
}
else if (i > j)
{
  int degree = Convert.ToInt32(Math.Pow(10, i - j));
  chr = Num / degree;
  chr = chr % 10;
  Console.WriteLine($"Число N = {Num} имеет {chr} разряд");
}
else Console.WriteLine($"Число N = {Num} не имеет такой цифры (Разряда)");
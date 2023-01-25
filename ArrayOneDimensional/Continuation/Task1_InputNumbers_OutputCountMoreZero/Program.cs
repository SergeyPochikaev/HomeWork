//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод ввода чисел М
// int[] Numbers()
// {
//   string[] array = Console.ReadLine()
//                           .Split(' ');
//   int[] arrayInt = new int[array.Length];
//   for (int i = 0; i < array.Length; i++)
//   {
//     //arrayInt[i] = Convert.ToInt32(array[i]);
//     arrayInt[i] = int.Parse(array[i]);
//   }
//   return arrayInt;
// }


// Метод - Условие ввода чисел
void InputCondition()
{
  Console.Clear();
  Console.WriteLine("Условие: Введите с клавиатуре любые целые M числа\nи при завершении ввода нажмите Enter");
  Console.WriteLine("------------------------------------------------");
  Console.Write("Ведите числа М через пробел= ");
}

// Метод подсчета количество чисел больше нуля
int CountMoreZero (int[] arrayInt)
{
  int count = 0;
  for (int i = 0; i < arrayInt.Length; i++)
  {
    if (arrayInt[i] > 0) count ++;
  }
  return count;
}
// Метод распечатки
string GoodPrint(int[] arrayInt, int count)
{
  return $"{String.Join(" ", arrayInt)} -> {count}";
}

InputCondition();
int[] array = Console.ReadLine()!
                     .Split(' ')
                     .Select(int.Parse)
                     .ToArray();
//int[] arrayInt = Numbers();
int count = CountMoreZero (array);
Console.WriteLine(GoodPrint(array, count));
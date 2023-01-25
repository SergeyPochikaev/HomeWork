//Задача 43: Напишите программу, которая найдёт точку пересечения
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

// Метод - Условие ввода чисел
void InputCondition()
{
  Console.Clear();
  Console.WriteLine("Условие: При вводе переменных линейного уравнения\nв виде дробных чисел разделяйте запятой!");
  Console.WriteLine("-------------------------------------------------");
}

// Метод вода коэф-в в линейном уравнение y=kx+b
double[] GetValuePoint(string varY)
{
  double[] array = new double[2];
  Console.Write($"Ведите коэффициенты линейного уравнения y{varY}:\nкоэффициент k{varY} = ");
  array[0] = Convert.ToDouble(Console.ReadLine());
  Console.Write($"коэффициент b{varY} = ");
  array[1] = Convert.ToDouble(Console.ReadLine());
  return array;
}

// Метод создание точки пересечения
double[] CreatePoint2D_v1(double[] varY1,
                          double[] varY2)
{
  double x = (varY2[1] - varY1[1]) / (varY1[0] - varY2[0]);
  double y = varY1[0] * x + varY1[1];
  return new double[] { x, y };
}

// Метод распечатки
string GoodPrint(double[] arrayInt)
{
  return $"({String.Join(";", arrayInt)})";
}

InputCondition();
double[] y1 = GetValuePoint("1");
double[] y2 = GetValuePoint("2");
double[] a = CreatePoint2D_v1(y1, y2);
if (y1[0] == y2[0])
{
  Console.WriteLine("Прямые параллельны и не имеют точки пересечения");
}
else Console.WriteLine(GoodPrint(a));

// (int, int, int) CreatePoint2D_v2()
// {
//   return (1,3,4);
// }

// (int, int, int) point = CreatePoint2D_v2();
// int a = point.Item1;

// (int x, int y, int z) point = CreatePoint2D_v2();
// int b = point.z;
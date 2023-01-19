//Задача 21: Напишите программу, принимает на вход координаты двух
//точек и находит расстояние между ними в 3D пространстве.

// Метод - Ввода точек по координатно
double GetValuePointA(string text)
{
  Console.Write($"Координата точки A {text}");
  return Convert.ToDouble(Console.ReadLine());
}

double GetValuePointB(string text)
{
  Console.Write($"Координата точки B {text}");
  return Convert.ToDouble(Console.ReadLine());
}

// Метод - получения расстояния м/у 2-мя точками
double GetDistance(double x1, double y1, double z1,
                   double x2, double y2, double z2)
{
  return Math.Sqrt(Math.Pow((x1 - x2), 2) +
                   Math.Pow((y1 - y2), 2) +
                   Math.Pow((z1 - z2), 2));
}


double x1 = GetValuePointA("x1 = "), y1 = GetValuePointA("y1 = "), z1 = GetValuePointA("z1 = "),
       x2 = GetValuePointB("x2 = "), y2 = GetValuePointB("y2 = "), z2 = GetValuePointB("z2 = ");
double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками A и B равна {distance}");

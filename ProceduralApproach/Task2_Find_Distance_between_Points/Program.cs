//Задача 21: Напишите программу, принимает на вход координаты двух
//точек и находит расстояние между ними в 3D пространстве.

// Метод - Ввода точек по координатно
double GetValuePoint(string text, string point)
{
  Console.Write($"Координата точки {point} {text}");
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


double x1 = GetValuePoint("x1 = ", "A"), y1 = GetValuePoint("y1 = ", "A"), z1 = GetValuePoint("z1 = ", "A"),
       x2 = GetValuePoint("x2 = ", "B"), y2 = GetValuePoint("y2 = ", "B"), z2 = GetValuePoint("z2 = ", "B");
double distance = Math.Round(GetDistance(x1, y1, z1, x2, y2, z2),2);
Console.WriteLine($"Расстояние между точками A и B равна {distance}");

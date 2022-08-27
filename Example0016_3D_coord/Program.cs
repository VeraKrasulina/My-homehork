Console.WriteLine("Введите координаты первой точки");
Console.Write(" X:  ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Y:  ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Z:  ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write(" X:  ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Y:  ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Z:  ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) + (y2 - y1) + (z2 - z1));
Console.WriteLine($"Расстояние между первой и второй точкой в пространстве равняется {result}");
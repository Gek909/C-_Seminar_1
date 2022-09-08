//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


double FindDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
    return distance;
}

Console.WriteLine("Input x1 - ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y1 - ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x2 - ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y2 - ");
double y2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(FindDistance(x1, y1, x2, y2), 3);
Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) равно {distance}");

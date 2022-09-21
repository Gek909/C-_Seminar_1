// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).

string FindPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    string xRes = $"({x.ToString()};";
    string yRes = $"{y.ToString()})";
    string result = xRes + yRes;
    return result;
}

Console.WriteLine("Уравнения прямых имеют вид:\n" +
    "y = k1 * x + b1\n" +
    "y = k2 * x + b2");
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

string result = FindPointOfIntersection(k1, b1, k2, b2);


if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые с заданными параметрами совпадают и имеют бесконечно много общих точек.");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые с заданными параметрами параллельны и не имеют общих точек.");
}
else
{
    Console.WriteLine($"Точка пересечения прямых с указанными параметрами -> {result}");
}


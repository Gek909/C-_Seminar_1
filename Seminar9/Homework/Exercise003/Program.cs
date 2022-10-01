// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

double GetNumberFromConsole()
{
    double number = double.Parse(Console.ReadLine());
    return number;
}

double AckermannsFunction(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0)
    {
        return AckermannsFunction(m - 1, 1);
    }

    return AckermannsFunction(m - 1, AckermannsFunction(m, n - 1));
}

Console.WriteLine("Введите неотрицательное число m: ");
double m = GetNumberFromConsole();

Console.WriteLine("Введите неотрицательное число n: ");
double n = GetNumberFromConsole();

double result = AckermannsFunction(m, n);
Console.WriteLine($"A({m},{n}) = {result}");
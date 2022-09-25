// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк (M): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (N): ");
int n = int.Parse(Console.ReadLine());

double[,] GetAndFillRandomDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] array = new double[m, n];
array = GetAndFillRandomDoubleArray(m, n);

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// Размерность массива (кол-во строк)
int n = 0;

// Размерность массива (кол-во стоsлбцов)
int m = 0;

Console.WriteLine("Введите количество строк (N): ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (N)");
    return;
}
else
{
    n = numberN;
}

Console.WriteLine("Введите количество столбцов (M): ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (M) ");
    return;
}
else
{
    m = numberM;
}

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j]);
    }
     Console.WriteLine();
}
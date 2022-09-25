// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.WriteLine("Введите количество строк (N): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (M): ");
int m = int.Parse(Console.ReadLine());

int[,] GetAndFillRandomArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetMainDiagonalSumOfElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i==j)
            {
                sum = sum + array[i,j];
            }
        }
    }
    return sum;
}

int[,] array = new int[n,m];
int sum = 0;

array = GetAndFillRandomArray(n,m);
PrintArray(array);
sum = GetMainDiagonalSumOfElements(array);
Console.WriteLine($"Сумма элементов на главной диагонали массива = {sum}.");

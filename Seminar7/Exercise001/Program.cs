// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк (M): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (N): ");
int n = int.Parse(Console.ReadLine());
 
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}

// TODO 1:43:21 и 2 задача.
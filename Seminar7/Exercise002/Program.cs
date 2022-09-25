// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.WriteLine("Введите количество строк (N): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (M): ");
int m = int.Parse(Console.ReadLine());


int[,] array = new int[n, m];
Console.WriteLine("Исходный массив:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if ((i % 2 == 0) & (j % 2 == 0))
        {
            array [i,j] = array[i,j]*array[i,j];
        }
    }
}
Console.WriteLine("Новый массив:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
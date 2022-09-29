// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = {
        {2, 4},
        {3, 2},
};

int[,] array2 = {
        {3, 4},
        {3, 3},
};

if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] prodResult = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < prodResult.GetLength(0); i++)
    {
        for (int j = 0; j < prodResult.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                prodResult[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    PrintArray(prodResult);
}
else
{
    Console.WriteLine("Для умножения количество столбцов первой матрицы должно равняться количеству строк второй.");
    return;
}

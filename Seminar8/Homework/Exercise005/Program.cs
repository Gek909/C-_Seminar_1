// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0 & j < 4)
        {
            array[i, j] = 1 + j;
        }
        else if (i < 4 & j == 3)
        {
            array[i, j] = 4 + i;
        }
        else if (i == 3 & j < 3)
        {
            array[i, j] = 10 - j;
        }
        else if (i < 3 & i > 0 & j == 0)
        {
            array[i, j] = 13 - i;
        }
        else if (i == 1 & j > 0 & j < 3)
        {
            array[i, j] = 12 + j;
        }
        else if (i == 2 & j > 0 & j < 3)
        {
            array[i, j] = 17 - j;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]}  ");
            }
            else
            {
                Console.Write($"{array[i, j]}  ");
            }
        }
        Console.WriteLine();
    }
}
PrintArray(array);

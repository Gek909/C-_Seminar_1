// //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите число строк: ");
int sizeN = GetNumberFromConsole();
Console.WriteLine("Введите число столбцов: ");
int sizeM = GetNumberFromConsole();

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = j;

            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }

            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
    }
}


int[,] array = new int[sizeN, sizeM];
array = GetAndFillRandomArray(sizeN, sizeM);

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);

SortArray(array);

Console.WriteLine("Отсортированный построчно массив:");
PrintArray(array);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int GetMinOfArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
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

int[] GetArraySumsOfRows(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i, j] + sum;
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void PrintMinRow(int[] sums, int min)
{
    string sameSum = String.Empty;
    for (int i = 0; i < sums.Length; i++)
    {
        if (sums[i] == min)
        {
            sameSum += " (" + Convert.ToString(i + 1) + ")";
        }
    }
    Console.WriteLine($"Номер(а) строк(и) с наименьшей суммой элементов -{sameSum}.");
}

int[,] array = new int[sizeN, sizeM];
array = GetAndFillRandomArray(sizeN, sizeM);

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);

int[] sums = GetArraySumsOfRows(array);

// Отображение массива сумм:
// void PrintArrayOfSum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

int min = GetMinOfArray(sums);

PrintMinRow(sums, min);
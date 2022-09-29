﻿// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] ReverseFirstAndLastRow(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            if (i == 0)
            {
                resultArray[i, j] = array[array.GetLength(0) - 1, j];
            }
            else if (i == resultArray.GetLength(0)-1)
            {
                resultArray[i, j] = array[0, j];
            }
            else resultArray[i, j] = array[i, j];
        }
    }
    return resultArray;
}



int[,] array = new int[sizeN, sizeM];
array = GetAndFillRandomArray(sizeN, sizeM);

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);

int[,] result = ReverseFirstAndLastRow(array);

Console.WriteLine("Массив, после замены первой и последней строки местами:");
PrintArray(result);

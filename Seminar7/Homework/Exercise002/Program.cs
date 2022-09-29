// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// а возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк (N): ");
int sizeN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (M): ");
int sizeM = int.Parse(Console.ReadLine());

int[,] GetAndFillRandomArray(int sizeN, int sizeM)
{
    int[,] array = new int[sizeN, sizeM];
    for (int i = 0; i < sizeN; i++)
    {
        for (int j = 0; j < sizeM; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < sizeN; i++)
    {
        for (int j = 0; j < sizeM; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

string GetElementUsingIndex(int[,] array, int sizeN, int sizeM, int n, int m)
{
    string element = "Элемента с указанным индексом не существует.";
    for (int i = 0; i < sizeN; i++)
    {
        for (int j = 0; j < sizeM; j++)
        {
            if (i == n & j == m)
            {
                element = "Элемент с указанным индексом: " + Convert.ToString(array[i, j]);
            }
        }
    }
    return element;
}

int[,] array = new int[sizeN, sizeM];
array = GetAndFillRandomArray(sizeN, sizeM);
Console.WriteLine("Массив с указанными параметрами: ");
PrintArray(array);

Console.WriteLine("Введите индекс строки (N): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца (M): ");
int m = int.Parse(Console.ReadLine());

string result = GetElementUsingIndex(array, sizeN, sizeM, n, m);
Console.WriteLine(result);

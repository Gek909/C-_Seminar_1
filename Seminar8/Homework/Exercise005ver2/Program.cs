// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

Console.WriteLine("Введите элементы массива 4х4 по порядку: ");
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = GetNumberFromConsole();
    }
}
for (int j = 3; j < 4; j++)
{
    for (int i = 1; i < 4; i++)
    {
        array[i, j] = GetNumberFromConsole();
    }
}

for (int i = 3; i < 4; i++)
{
    for (int j = 2; j >= 0; j--)
    {
        array[i, j] = GetNumberFromConsole();
    }
}
for (int j = 0; j < 1; j++)
{
    for (int i = 2; i > 0; i--)
    {
        array[i, j] = GetNumberFromConsole();
    }
}
for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < 3; j++)
    {
        array[i, j] = GetNumberFromConsole();
    }
}
for (int i = 2; i < 3; i++)
{
    for (int j = 2; j > 0; j--)
    {
        array[i, j] = GetNumberFromConsole();
    }
}

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
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
Console.WriteLine("Спирально заполненный массив введенными элементами: ");
PrintArray(array);



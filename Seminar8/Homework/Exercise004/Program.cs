// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите целое число 1ого измерения массива: ");
int sizeN = GetNumberFromConsole();
Console.WriteLine("Введите целое число 2ого измерения массива: ");
int sizeM = GetNumberFromConsole();
Console.WriteLine("Введите целое число 3его измерения массива: ");
int sizeP = GetNumberFromConsole();

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})  ");
            }
        }
    }
}

int[,,] array = new int[sizeN, sizeM, sizeP];

Console.WriteLine("Введите двузначные неповторяющиеся элементы массива по порядку: ");
for (int i = 0; i < sizeN; i++)
{
    for (int j = 0; j < sizeM; j++)
    {
        for (int k = 0; k < sizeP; k++)
        {
            array[i, j, k] = GetNumberFromConsole();
        }
    }
}

Console.WriteLine();
PrintArray(array);
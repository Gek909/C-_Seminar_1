// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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


int[,] array = new int[,]
{
    {3, 2, 5},
    {5, 6, 8},
    {6, 1, 9},
};

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);

int min = array[0, 0];

int minRow = 0;
int minColumn = 0;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            minRow = i;
            minColumn = j;
        }
    }
}

Console.WriteLine(minRow);
Console.WriteLine(minColumn);

int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (i < minRow & j < minColumn)
        {
            newArray[i, j] = array[i, j];
        }
        else if (i < minRow & j == minColumn)
        {
            newArray[i, j] = array[i, j + 1];
        }
        else if (i == minRow & j < minColumn)
        {
            newArray[i, j] = array[i + 1, j];
        }
        // TODO описать все возможные итерации.
    }

}


Console.WriteLine("Массив с указанными параметрами:");
PrintArray(newArray);
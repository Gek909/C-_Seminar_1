// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int GetNumberOfElements(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count++;
            }
        }
    }
    return count;
}

int GetMaxOfArray(int[,] array)
{
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
    }
    return max;
}

int GetMinOfArray(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
    }
    return min;
}

int[,] array = new int[sizeN, sizeM];
array = GetAndFillRandomArray(sizeN, sizeM);

Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);

int max = GetMaxOfArray(array);
int min = GetMinOfArray(array);

int tempNumber = min;

while (tempNumber >= min & tempNumber <= max)
{
    int numberOfElement = GetNumberOfElements(array, tempNumber);
    if (numberOfElement != 0)
    {
        Console.WriteLine($"{tempNumber} встречается в массиве {numberOfElement} раз(а)");
    }
    tempNumber++;
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк (N): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (M): ");
int m = int.Parse(Console.ReadLine());

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
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

string GetArithmeticMeanInEachColumn(int[,] array)
{
    string resultText = string.Empty;
    double result = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result = array[j, i] + result;
        }
        result = result / n;
        resultText = resultText + Convert.ToString(Math.Round(result,2))+"  ";
        result = 0;
    }
    return resultText;
}


int[,] array = new int[n, m];
array = GetAndFillRandomArray(n, m);
Console.WriteLine("Массив с указанными параметрами:");
PrintArray(array);
string res = GetArithmeticMeanInEachColumn(array);
Console.WriteLine($"Среднее арифметическое каждого столбца:\n"+
$"{res}");


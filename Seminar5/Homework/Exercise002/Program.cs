//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateAndFillArray()
{
    int[] array = new int[10];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}


int GetSumOfOddArrayIndexes(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = array[i] + sum;
    }
    return sum;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]},");
        if ((i > 0) & (i < array.Length - 1)) Console.Write($"{array[i]},");
        if (i == array.Length - 1) Console.Write($"{array[i]}]");
    }
}

int[] array = CreateAndFillArray();
PrintArray(array);
int sum = GetSumOfOddArrayIndexes(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, находящихся на нечётных позициях равна {sum}.");
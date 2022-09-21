//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] arrayclone = new int[array.Length];
    for (int i = 0; i < arrayclone.Length; i++)
    {
        arrayclone[i] = array[i];
    }
    return arrayclone;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}  ");
        if ((i > 0) & (i < array.Length - 1)) Console.Write($"{array[i]}  ");
        if (i == array.Length - 1) Console.Write($"{array[i]}]");
    }
}

int[] array = new int[] { 1, 3, 5, 6, 7, 8, 10, 21 };

int[] arraycopy = CopyArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(arraycopy);
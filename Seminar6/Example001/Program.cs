// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
int[] GetReverseArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
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

// 2ой вариант решения через переменную:
int[] GetReverseArray2(int[] array)
{
    int tempStorage = array[0];
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempStorage = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = tempStorage;
    }
    return array;
}

int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] result = GetReverseArray2(array);
PrintArray(result);



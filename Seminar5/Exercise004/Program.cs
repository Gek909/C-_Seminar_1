// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

int[] ArrayPairProduct(int[] array)
{
    int length = array.Length;
    if (length % 2 == 0)
    {
        int[] newArray = new int[array.Length / 2];
        for (int i = 0; i < newArray.Length; i++)
        {   
            for (int j = 0; j < array.Length; j++)
            {
                newArray[i] = array[j] * (array[array.Length - (j + 1)]);
            }

        }
        return newArray;
    }
    return array;
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
int[] newArray = ArrayPairProduct(array);
PrintArray(newArray);
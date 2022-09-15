// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] CreateAndFillArray()
{
    int[] array = new int[123];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 1000);
    }
    return array;
}

int ArrayCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] > 9) & (array[i] < 100))
        {
            count = count + 1;
        }
    }
    return count;
}



int[] array = CreateAndFillArray();

int count = ArrayCheck(array);

Console.WriteLine($"Количество элементов массива со значением в диапазоне [10,99] - {count}");

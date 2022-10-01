// Сортировка массива  
void BubbleSortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void PrintArrayOfSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[] array = new int[] { 2, 5, 6, 7, 2, 1, 5, 7, 9, 0 };

BubbleSortArray(array);

PrintArrayOfSum(array);
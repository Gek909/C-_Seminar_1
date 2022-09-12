// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[] array = GetArray();
PrintArray(array);
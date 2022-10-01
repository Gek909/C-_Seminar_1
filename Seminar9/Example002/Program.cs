// Ввести в массив неповторяющиеся элементы

bool SearchElem(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return true;
        }
    }
    return false;
}

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    bool flag = false;
    while (flag != true)
    {
        flag = false;

        int temp = new Random().Next(1, 15);
        if (SearchElem(array, temp))
        {
            continue;
        }
        else
        {
            array[i] = temp;
            flag = true;
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

PrintArrayOfSum(array);
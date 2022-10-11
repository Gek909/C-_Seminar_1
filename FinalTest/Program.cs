// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}


string GetStringFromConsole()
{
    string text = Console.ReadLine();
    return text;
}


string[] FillArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = GetStringFromConsole();
    }
    return array;
}


void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else if (array.Length == 1)
    {
        Console.Write($"[{array[0]}]");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0) Console.Write($"[{array[i]}, ");
            if ((i > 0) & (i < array.Length - 1)) Console.Write($" {array[i]}, ");
            if (i == array.Length - 1) Console.Write($" {array[i]}]");
        }
    }
}


string[] GetThreeOrLessCharElements(string[] array, string[] newArray)
{
    int newArrayIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newArrayIndex] = array[i];
            newArrayIndex++;
        }
    }
    return newArray;
}

int GetNewArraySize(string[] array)
{
    int newArraySize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArraySize++;
        }
    }
    return newArraySize;
}

Console.WriteLine("Введите целое число, равное количеству элементов инициируемого массива: ");

int size = GetNumberFromConsole();
string[] array = new string[size];

Console.WriteLine("Введите элементы массива по порядку: ");

array = FillArray(array, size);
int newArraySize = GetNewArraySize(array);
string[] newArray = new string[newArraySize];
newArray = GetThreeOrLessCharElements(array, newArray);
PrintArray(newArray);



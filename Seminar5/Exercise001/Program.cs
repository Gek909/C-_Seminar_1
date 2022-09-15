// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ReversePositiveToNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
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

int[] array = new int[4];

Console.WriteLine("Введите 1ый элемент массива: ");
array[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ой элемент массива: ");
array[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3ий элемент массива: ");
array[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 4ый элемент массива: ");
array[3] = int.Parse(Console.ReadLine());

int[] reversedArray = ReversePositiveToNegative(array);
PrintArray(reversedArray);




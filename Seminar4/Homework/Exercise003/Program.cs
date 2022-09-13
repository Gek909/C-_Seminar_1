//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]},");
        if ((i > 0) & (i < array.Length-1)) Console.Write($"{array[i]},");
        if (i == array.Length-1) Console.Write($"{array[i]}]");
    }

}


int[] array = new int[8];
Console.WriteLine("Введите 1ый элемент массива: ");
array[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ой элемент массива: ");
array[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3ий элемент массива: ");
array[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 4ый элемент массива: ");
array[3] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 5ый элемент массива: ");
array[4] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 6ой элемент массива: ");
array[5] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 7ой элемент массива: ");
array[6] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 8ой элемент массива: ");
array[7] = int.Parse(Console.ReadLine());

Console.WriteLine();
PrintArray(array);
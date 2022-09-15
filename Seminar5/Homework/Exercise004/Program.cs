// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}  ");
        if ((i > 0) & (i < array.Length - 1)) Console.Write($"{array[i]}  ");
        if (i == array.Length - 1) Console.Write($"{array[i]}]");
    }
}

double GetDifferenceBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    dif = max - min;
    return dif;
}


double[] array = new double[8];

Console.WriteLine("Введите 1ый элемент массива: ");
array[0] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ой элемент массива: ");
array[1] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 3ий элемент массива: ");
array[2] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 4ый элемент массива: ");
array[3] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 5ый элемент массива: ");
array[4] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 6ой элемент массива: ");
array[5] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 7ой элемент массива: ");
array[6] = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 8ой элемент массива: ");
array[7] = double.Parse(Console.ReadLine());


PrintArray(array);
double dif = GetDifferenceBetweenMaxAndMin(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {dif}.");
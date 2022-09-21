// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetFiboNumbersToN(int num)
{
    int[] fibo = new int[num];
    fibo[0] = 0;
    fibo[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
    }
    return fibo;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"{array[i]}  ");
        if ((i > 0) & (i < array.Length - 1)) Console.Write($"{array[i]}  ");
        if (i == array.Length - 1) Console.Write($"{array[i]}");
    }
}



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 1)
{
    int[] fibo = GetFiboNumbersToN(number);
    PrintArray(fibo);
}

if (number == 1)
{
    Console.WriteLine("0 1");
}

if (number == 0)
{
    Console.WriteLine("0");
}
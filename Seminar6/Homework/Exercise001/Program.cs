// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых элементов: ");
int amountOfNumbers = int.Parse(Console.ReadLine());
int[] array = new int[amountOfNumbers];

for (int i = 0; i < amountOfNumbers; i++)
{
    Console.WriteLine("Введите элемент: ");
    array[i] = int.Parse(Console.ReadLine());
}

int GetAmountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}  ");
        if ((i > 0) & (i < array.Length - 1)) Console.Write($"{array[i]}  ");
        if (i == array.Length - 1) Console.Write($"{array[i]}]");
    }
}

int result = GetAmountOfPositiveNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Среди данных элементов {result} больше нуля.");



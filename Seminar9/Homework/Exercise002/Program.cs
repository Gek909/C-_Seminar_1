// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите число M: ");
int numberM = GetNumberFromConsole();

Console.WriteLine("Введите число N (N > M): ");
int numberN = GetNumberFromConsole();

int GetSumMToN(int numberM, int numberN)
{
    if (numberN == numberM)
    {
        return numberN;
    }
    int sum = numberN + GetSumMToN(numberM, numberN - 1);
    return sum;
}

int sum = GetSumMToN(numberM, numberN);
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} => {sum}");

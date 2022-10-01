// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

string ShowNumbersMToN(int numberM, int numberN)
{
    if (numberN == numberM)
    {
        return $"{numberN}";
    }
    string result = ShowNumbersMToN(numberM, numberN - 1) + " " + numberN;
    return result;
}

Console.WriteLine("Введите число M: ");
int numberM = GetNumberFromConsole();

Console.WriteLine("Введите число N: ");
int numberN = GetNumberFromConsole();

string result = ShowNumbersMToN(numberM, numberN);

Console.WriteLine($"Числа от M до N => {result}");



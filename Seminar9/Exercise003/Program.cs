// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetSumOfDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    int sum = number % 10 + GetSumOfDigits(number / 10);
    return sum;
}

Console.WriteLine("Введите число N: ");
int number = GetNumberFromConsole();

int sum = GetSumOfDigits(number);
Console.WriteLine(sum);
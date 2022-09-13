// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumOfDigits(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = Math.Abs(GetSumOfDigits(number));
Console.WriteLine($"Сумма цифр в числе {number} - {result}");


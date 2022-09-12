// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetNumberOfDigits (int number)
{
    int num = Math.Abs(number);
    string absoluteValue = Convert.ToString(num);
    int length = absoluteValue.Length;
    return length;
}


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int length = GetNumberOfDigits(number);
Console.WriteLine($"Количество цифр в числе - {length}");



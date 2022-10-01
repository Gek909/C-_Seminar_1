// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N (+ их сумму).

string ShowNumbers1ToN(int number)
{
    if (number == 1)
    {
        return "1";
    }
    string result = ShowNumbers1ToN(number - 1) + " " + number;
    return result;
}

int GetSumNumbers1ToN(int number)
{
    if (number == 1)
    {
        return 1;
    }
    int sum = number + GetSumNumbers1ToN(number - 1);
    return sum;
}

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}
Console.WriteLine("Введите число N: ");
int number = GetNumberFromConsole();
string result = ShowNumbers1ToN(number);
Console.WriteLine(result);
int sum = GetSumNumbers1ToN(number);
Console.WriteLine($"Сумма чисел от 1 до {number} - {sum}");

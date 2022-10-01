//  Задача 65: Задайте значения M и N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от M до N (+ их сумму).
// TODO: 2 задача и 2:10 семинар.
string ShowNumbers1ToN(int numberN, int numberM)
{
    if (numberN == numberM)
    {
        return $"{numberM}";
    }
    string result = ShowNumbers1ToN((numberN - 1), numberM) + " " + numberN;
    return result;
}

int GetSumNumbers1ToN(int numberN, int numberM)
{
    if (numberN == numberM)
    {
        return numberM;
    }
    int sum = numberN + GetSumNumbers1ToN((numberN - 1), numberM);
    return sum;
}

int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}
Console.WriteLine("Введите число M: ");
int numberM = GetNumberFromConsole();

Console.WriteLine("Введите число N: ");
int numberN = GetNumberFromConsole();

string result = ShowNumbers1ToN(numberN, numberM);
Console.WriteLine(result);

int sum = GetSumNumbers1ToN(numberN, numberM);
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} - {sum}");

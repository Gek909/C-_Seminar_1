// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


int GetNumberFromConsole()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите число A: ");
int a = GetNumberFromConsole();

Console.WriteLine("Введите целое число B: ");
int b = GetNumberFromConsole();

int GetAToPowB(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    int result = a*GetAToPowB(a,b-1);
    return result;
}

int result = GetAToPowB(a,b);
Console.WriteLine($"Число {a} в степени {b} - {result}");

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int[] NumberToArray(int num)
{
    int[] number = new int[5];
    for (int i = 4; i >= 0; i = i - 1)
    {
        number[i] = num % 10;
        num = num / 10;
    }
    return number;
}


string PalindromeCheck(int[] array)
{
    if (array[0] == array[4] & array[1] == array[3])
    {
        return "палиндром";
    }
    else
    {
        return "не палиндром";
    }
}


Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int[] array = NumberToArray(num);
string message = PalindromeCheck(array);
Console.WriteLine($"Число {num} - {message}");

// See https://aka.ms/new-console-template for more information

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int num = GetNumber();

Console.WriteLine(num);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int div = number1 % number2;
if (div == 0)
    {
    Console.WriteLine("Кратно");
    }
else Console.WriteLine($"Не кратно, остаток {div}");
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

// Определение входных чисел:

Console.WriteLine("Введите 1ое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ое число: ");
int number2 = int.Parse(Console.ReadLine());

// Проверка чисел на квадрат

if (number2 * number2 == number1)
    {
       Console.WriteLine($"Квадрат числа {number2} соответствует {number1}"); 
    }
else
    {
        Console.WriteLine($"Квадрат числа {number2} не соответствует {number1}");
    }
// Программа, которая принимает на вход 3ехзначное число и на выходе показывает 2ую цифру этого числа.


void secondDigitShow (int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    Console.WriteLine($"Вторая цифра числа {num} - {num2}");
}

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

secondDigitShow(num);
// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 10, 100, 10000

void thirdDigitShow(int num)
{
    if ((num < 100) & (num > -100))
    {
        Console.WriteLine("Третьей цифры нет");
    }

    else
    {
        while ((num > 1000) | (num <-1000))
        {
            num = num / 10;
        }
        int result = num % 10;
        Console.WriteLine(Math.Abs(result));
    }
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

thirdDigitShow(num);
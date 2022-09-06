void CompareDigits ()
    {
    int number = new Random().Next(10, 100);
    int number1 = number / 10;
    int number2 = number % 10;
    Console.WriteLine($"Сгенерированно случайное число {number}");
    if (number1 > number2) Console.WriteLine("Первая цифра больше");
    else if (number2 > number1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром");
    }

CompareDigits ();
CompareDigits ();

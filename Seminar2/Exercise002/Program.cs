// Генерируем случайное 3ех значное число, из него убираем 2ую цифру.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированно случайное число {number}");
int number1 = number / 100 * 10;
int number2 = number % 10;
int result = number1 + number2;
Console.WriteLine(result);


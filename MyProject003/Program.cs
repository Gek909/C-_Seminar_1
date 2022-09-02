// Определение входного числа

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

int startNumber = Math.Abs(number) * -1;

while (startNumber <= number) 
{
    Console.WriteLine(startNumber);
    startNumber++;
}

    
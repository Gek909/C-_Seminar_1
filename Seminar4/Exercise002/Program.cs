// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetProduct1ToN(int number)
{
    if (number >= 1)
        {
        int product = 1;
        for (int i = 1; i <= number; i++)
        {
            product = product * i;
        }
        return product;
    }

    else return 0;
       
}


Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int product = GetProduct1ToN(number);
Console.WriteLine($"Произведение чисел от 1 до N - {product}");
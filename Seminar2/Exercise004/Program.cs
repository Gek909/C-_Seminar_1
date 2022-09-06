// See https://aka.ms/new-console-template for more information

void multiplicity(int num1)
{
    if ((num1 % 7 == 0) & (num1 % 23 == 0))
        {
            Console.WriteLine("Да");
        }
    else Console.WriteLine("Нет");
}

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

multiplicity(num1);
Console.WriteLine();
// Программа, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом другого.

void numSquareCheck(int num1, int num2)
{
    if ((num2 * num2 == num1) | (num1 * num1 == num2)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.WriteLine("Введите 1ое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2ое число: ");
int num2 = int.Parse(Console.ReadLine());

numSquareCheck(num1, num2);
Console.WriteLine();

//void numbers(int num1, int num2)
//{
//    if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
//    else Console.WriteLine($"Первое число не кратно второму, остаток {num1 % num2}");
//
//}
//
//Console.Write("Введите первое число: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int num2 = int.Parse(Console.ReadLine());

//numbers(num1, num2);
//Console.WriteLine();

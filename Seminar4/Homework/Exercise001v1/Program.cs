// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.


double RaiseAToPowB(double a, double b)
{
    double result = Math.Pow(a,b);
    return result;
}


Console.WriteLine("Введите число A:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число B:");
double b = double.Parse(Console.ReadLine());

double result = RaiseAToPowB(a,b);
Console.WriteLine($"{a} в степени {b} = {result}");




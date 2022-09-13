// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.


double RaiseAToPowB(double a, double b)
{
    if (b > 0)
    {
        double result = 1;
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        return result;
    }
    else if (b == 0) return 1;
    else return 0;

}


Console.WriteLine("Введите число A:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число B:");
double b = double.Parse(Console.ReadLine());

double result = RaiseAToPowB(a, b);
if (result == 0) Console.WriteLine("Ошибка. Число B должно быть натуральным.");
else Console.WriteLine($"{a} в степени {b} = {result}");





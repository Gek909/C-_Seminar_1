// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

string TriangleCheck(int a, int b, int c)
{
    string result = "Треугольник с заданными сторонами не может существовать.";
    if (a < (b+c) & b < (a+c) & c < (a+b))
    {
        result = "Треугольник с заданными сторонами может существовать.";
        return result;
    }
    else return result;
}


Console.WriteLine("Введите сторону A: ");
int sideA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону B: ");
int sideB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону C: ");
int sideC = int.Parse(Console.ReadLine());

string result = TriangleCheck(sideA, sideB, sideC);
Console.WriteLine(result);
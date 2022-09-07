// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void WeekendCheck(int num)
{
    if ((num >= 1) & (num < 6)) Console.WriteLine("Не выходной");
    else if ((num == 6) | (num == 7)) Console.WriteLine("Выходной");  
    else Console.WriteLine("Введите число от 1 до 7");
}


Console.WriteLine("Введите число, соответствующее дню недели: ");
int num = int.Parse(Console.ReadLine());

WeekendCheck(num);


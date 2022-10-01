// See https://aka.ms/new-console-template for more information
int Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    if (n == 0)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

int result = Factorial(5);
Console.WriteLine(result);
// See https://aka.ms/new-console-template for more information


string GetCoordinates(int areaNumber)
{
    if (areaNumber == 1)
    {
        return "x > 0, y > 0";
    }
     if (areaNumber == 2)
    {
        return "x < 0, y > 0";
    }
     if (areaNumber == 3)
    {
        return "x < 0, y < 0";
    }
     if (areaNumber == 4)
    {
        return "x > 0, y < 0";
    }
    return "Input number from 1 to 4";
}

Console.WriteLine("Input Area number: ");
int areaNumber = Convert.ToInt32(Console.ReadLine());

string message = GetCoordinates(areaNumber);
Console.WriteLine(message);



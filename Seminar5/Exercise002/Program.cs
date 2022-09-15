// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


string NumberCheck(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return "yes";
            break;
        }
    }
    return "no";
}

int[] array = new int[5];

Console.WriteLine("Введите 1ый элемент массива: ");
array[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ой элемент массива: ");
array[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3ий элемент массива: ");
array[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 4ый элемент массива: ");
array[3] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 5ый элемент массива: ");
array[4] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число, которое необходимо найти в массиве: ");
int number = int.Parse(Console.ReadLine());

string result = NumberCheck(array, number);
if (result == "yes") Console.WriteLine($"Число {number} присутствует в массиве");
if (result == "no") Console.WriteLine($"Число {number} отсутствует в массиве");


// Программа, принимающая число n и выводящая на экран таблицу квадратов чисел от 1 до n.
// Версия с массивом и методом:
//

int[] SquaresTable(int num)
{
    int[] squareNumbers = new int[num];

    // Заполнение массива результата
    for (int i = 1; i <= num; i++)
    {
        squareNumbers[i - 1] = i * i;
    }
    return squareNumbers;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] result = SquaresTable(num);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

// Рабочая версия без метода (самая простая):
//for (int i = 1; i <= num; i++)
//    {
//        int result = i*i;
//        Console.Write($"{result},");
//    }

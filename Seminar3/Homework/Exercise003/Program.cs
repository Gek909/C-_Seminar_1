// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int[] CubeList(int num)
{
    int[] array = new int[num];

    for (int i = 1; i <= num; i++)
    {
        array[i - 1] = i * i * i;
    }
    return array;
}


Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] result = CubeList(num);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}


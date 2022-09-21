// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

//  Console.WriteLine("Введите число:");
//  int number = int.Parse(Console.ReadLine());
//  
//  string NumberToBinary(int num)
//  {
//      string result = "";
//      if (num > 2)
//      {
//              while (num > 0)
//          {
//              result = result + Convert.ToString(num % 2);
//              num = num / 2;
//          }
//      }
//      else result = 
//      
//      return result;
//  }
//  
//  string result = NumberToBinary(number);
//  Console.WriteLine(result);


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

string GetReversedResult(int num)
{
    num = Math.Abs(num);
    string reversedResult = "";
    while (num > 0)
    {
        reversedResult = reversedResult + Convert.ToString(num % 2);
        num = num / 2;
    }

    return reversedResult;
}

char[] GetCorrectResult(string reversedResult)
{
    char[] result = reversedResult.ToCharArray();
    Array.Reverse(result);
    return result;
}

void PrintArray(char[] array, int num)
{
    if (num >= 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
    else
    {
        Console.Write("-");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }

}

string reversedResult = GetReversedResult(number);
char[] result = GetCorrectResult(reversedResult);
PrintArray(result, number);

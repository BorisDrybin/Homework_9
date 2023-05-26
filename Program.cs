// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(n);

// void PrintNumbers(int n)
// {
//     if(n < 1)
//     {
//         return;
//     }
//     Console.Write($"{n} ");
//     PrintNumbers(n - 1);
// }


//  Задайте значения M и N. Напишите программу, 
//  которая найдёт сумму натуральных элементов 
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");

if(m > n)
{
    Console.WriteLine("Неверные данные");
    return;
}

Console.Write(SumNumbers(m, n));

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else return m + SumNumbers(m + 1, n);
}
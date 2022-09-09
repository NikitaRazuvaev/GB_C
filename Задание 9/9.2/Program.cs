/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int InputNum(string name)
{
    Console.Write($"Введите {name}: ");

    int result;

    while (true)
    {
        try
        {
            result = int.Parse(Console.ReadLine());
            if (result > 0)
            {
                return result;
            }
            Console.WriteLine($"Ввели не положительное число. Введите положительное число {name}, пожалуйста:");
        }
        catch
        {
            Console.Write($"Введено не число. Введите число {name}, пожалуйста:");
        }
    }
}

int SumNum(int n, int m)
{
    int a, b;
    if (n > m)
    {
        b = n;
        a = m;
    }
    else
    {
        b = m;
        a = n;
    }
    return (a + b) * (b - a + 1) / 2;
}

int SummNumRecurse(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    if (n > m)
    {
        return m + SummNumRecurse(m + 1, n);
    }
    return n + SummNumRecurse(n + 1, m);
}
Console.Clear();

int n = InputNum("N");
int m = InputNum("M");
Console.WriteLine($"Результат по формуле: {SumNum(n,m)}");
Console.WriteLine($"Результат по рекурсивной функции: {SummNumRecurse(n,m)}");
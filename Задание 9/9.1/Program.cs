/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
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

void TheRange(int n, int m)
{
    int i;
    if (n < m)
        for (i = n; i <= m; i++)
            Console.Write($" {i}");
    else
        for (i = m; i <= n; i++)
            Console.Write($" {i}");

}


Console.Clear();

int n = InputNum("N");
int m = InputNum("M");

TheRange(n, m);







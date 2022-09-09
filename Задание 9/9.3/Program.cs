/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
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

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}


Console.Clear();

int n = InputNum("N");
int m = InputNum("M");
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Akkerman(m, n)}");
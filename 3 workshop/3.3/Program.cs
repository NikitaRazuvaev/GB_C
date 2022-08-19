// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
static int InputNum(string name)
{
    Console.Write($"Введите {name}: ");
    while (true)
    {
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write($"Введено не число. Введите число {name}, пожалуйста:");
        }
    }
}

Console.Clear();

int N = InputNum("N");

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i < N)
    {
        Console.Write(", ");
    }
}

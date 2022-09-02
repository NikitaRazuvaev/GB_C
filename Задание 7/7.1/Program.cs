
Console.Clear();

int InputNum(string name)
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


int m = InputNum("m");
int n = InputNum("n");



double[,] arrary = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arrary[i, j] = rnd.NextDouble() * 2 - 1;
    
    }
}

Console.WriteLine("Результат:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arrary[i, j].ToString("##0.0 "));
    }
    Console.WriteLine();
}



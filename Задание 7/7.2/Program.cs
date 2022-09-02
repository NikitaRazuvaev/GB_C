// See https://aka.ms/new-console-template for more information
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



Random random = new Random();
int n = random.Next(3, 7);
int m = random.Next(3, 7);



int[,] arrary = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arrary[i, j] = random.Next(1, 10);

    }
}

Console.WriteLine("Массив: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($" {arrary[i, j]}");
    }
    Console.WriteLine();
}
int x = InputNum("строку x");
int y = InputNum("столбец y");
if (y < 1 | y > n | x < 1 | x > m)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arrary[x - 1, y - 1]);
}
Console.ReadLine();


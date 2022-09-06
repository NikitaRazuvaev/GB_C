/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


Random random = new Random();

bool isinarray(int[,,] x, int y)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            for (int k = 0; k < x.GetLength(2); k++)
            {
                if (y == x[i, j, k])
                {
                    return true;
                }

            }
        }
    }
    return false;
}
int[,,] CreateArray(int h, int w, int z)
{
    int[,,] x = new int[w, h, z];
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            for (int k = 0; k < x.GetLength(2); k++)
            {
                int candidate = random.Next(10, 99);
                while (isinarray(x, candidate))
                {
                    candidate = random.Next(10, 99);
                }
                x[i, j, k] = candidate;
            }
        }
    }
    return x;
}
void PrintArray(int[,,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            for (int k = 0; k < x.GetLength(2); k++)
            {
                Console.Write($"{x[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
PrintArray(CreateArray(3,3,3));
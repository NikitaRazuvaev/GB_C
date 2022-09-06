/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Random random = new Random();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArray(int h, int w)
{
    int[,] array = new int[w, h];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

int[,] multiplication(int[,] matrixA, int[,] matrixB)
{
    int limit = Math.Min(matrixA.GetLength(1), matrixB.GetLength(0));
    int[,] resultA = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < resultA.GetLength(0); i++)
    {
        for (int j = 0; j < resultA.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < limit; r++)
            {
                sum = sum + matrixA[i, r] * matrixB[r, j];
            }
            resultA[i, j] = sum;
        }
    }
    return resultA;
}
Console.Clear();

int[,] matrixA = CreateArray(2, 2);
int[,] matrixB = CreateArray(2, 2);

Console.WriteLine("Матрица A:");
PrintArray(matrixA);
Console.WriteLine("Матрица B:");
PrintArray(matrixB);
Console.WriteLine("Результат");
PrintArray(multiplication(matrixA,matrixB));
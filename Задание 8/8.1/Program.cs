/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] SortVozrast(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)// перечисление строк
    {
        for (int j = 0; j < x.GetLength(1); j++)// перечисление символов(столбцов)
        {
            for (int q = j; q < x.GetLength(1); q++)//перечесления строк для проверки
            {
                {
                    if (x[i, j] > x[i, q])
                    {
                        int minVal = x[i, q];
                        x[i, q] = x[i, j];
                        x[i, j] = minVal;
                    }
                }
            }
        }
    }
    return x;
}

int[,] SortUbiv(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)// перечисление строк
    {
        for (int j = 0; j < x.GetLength(1); j++)// перечисление символов(столбцов)
        {
            for (int q = j; q < x.GetLength(1); q++)//перечесления строк для проверки
            {
                {
                    if (x[i, j] < x[i, q])
                    {
                        int minVal = x[i, q];
                        x[i, q] = x[i, j];
                        x[i, j] = minVal;
                    }
                }
            }
        }
    }
    return x;
}

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

Console.Clear();

Random random = new Random();

int[,] array = new int[random.Next(2, 5), random.Next(2, 5)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
    }
}

PrintArray(array);

Console.WriteLine("введите вариант сортировки!\n u убывание\n v возрастание");

switch (Console.ReadLine())
{
    case "u":
        array = SortUbiv(array);
        break;
    case "v":
        array = SortVozrast(array);
        break;
}

Console.WriteLine($"Результат: ");
PrintArray(array);

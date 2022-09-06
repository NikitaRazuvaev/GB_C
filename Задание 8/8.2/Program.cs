/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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


int summin(int[,] array)
{
    int min = int.MaxValue;
    int minindex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum = array[i, j] + sum;
        }
        if (min > sum)
        {
            minindex=i;
            min = sum;
        }
    }
    return minindex;
}



Console.Clear();


Random random = new Random();

int[,] array = new int[random.Next(2, 6), random.Next(2, 8)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);

    }
}
PrintArray(array);
Console.WriteLine($"Результат: № строки {summin(array)+1}");





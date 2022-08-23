// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

int fillarray(int[] buffer, int limit)
{
    string[] input = Console.ReadLine().Split(',');
    int i;
    for (i = 0; i < Math.Min(input.Count(), limit); i++)
    {
        buffer[i] = int.Parse(input[i]);
    }

    return i;
}
void printarray(int[] buffer, int count)
{

    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(buffer[i]);
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
     Console.Write("]");
}

Console.Clear();

Console.Write("Введите числа через запятую :");

int num = fillarray(array, 8);

Console.Write($"Вы ввели {num} чисел:");
printarray(array, num);
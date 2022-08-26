/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine("Hello, World!");
Random rnd = new Random();

Console.Clear();

double[] CreadteArray(int count)
{
    double[] Rezult = new double[count];
    for (int i = 0; i < count; i++)
    {
        Rezult[i] = rnd.NextDouble();
    }
    return Rezult;

}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Count(); i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Count(); i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Count(); i++)
    {
        Console.Write(array[i]);
        if (i < array.Count() - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


// double[] randomdata = CreadteArray(3);

double[] randomdata = {3, 7, 22, 2, 78};
PrintArray(randomdata);
Console.Write($"Вывод: {Max(randomdata) - Min(randomdata)} ");
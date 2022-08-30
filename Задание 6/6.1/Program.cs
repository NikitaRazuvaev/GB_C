// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();

Console.Write("Введите числа через пробел: ");

static int ParseIntNum(string value)
{
    try
    {
        return int.Parse(value);
    }
    catch
    {
        Console.WriteLine($"Введено не число.{value}");
        throw;
    }
}

int CountGreateZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = Array.ConvertAll(Console.ReadLine().Split(), ParseIntNum);

Console.Write($"Количество элементов > 0: {CountGreateZero(array)} ");


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
Console.Clear();

double InputNum(string name)
{
    Console.Write($"Введите {name}: ");
    while (true)
    {
        try
        {
            return double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write($"Введено не число. Введите число {name}, пожалуйста:");
        }
    }
}

double CalcIntersectionX(double a, double c, double b, double d)
{
    return (d - c) / (a - b);
}

double CalcIntersectionY(double a, double c, double b, double d)
{
    return a * (d - c) / (a - b) + c;
}

double b1 = InputNum(nameof(b1));
double k1 = InputNum(nameof(k1));
double b2 = InputNum(nameof(b2));
double k2 = InputNum(nameof(k2));

Console.WriteLine($"Точка пересечения: ({CalcIntersectionX(k1, b1, k2, b2)}; {CalcIntersectionY(k1, b1, k2, b2)})");





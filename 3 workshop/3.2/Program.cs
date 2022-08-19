//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

static double InputCoord()
{
    while (true)
    {
        try
        {
            return double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write("Введено не число. Введите число, пожалуйста:");
        }
    }
}

Console.Clear();

Console.WriteLine("Введите x1:");
double x1 = InputCoord();

Console.WriteLine("Введите x2:");
double x2 = InputCoord();

Console.WriteLine("Введите y1:");
double y1 = InputCoord();

Console.WriteLine("Введите y2:");
double y2 = InputCoord();

Console.WriteLine("Введите z1:");
double z1 = InputCoord();

Console.WriteLine("Введите z2:");
double z2 = InputCoord();

double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine(res);

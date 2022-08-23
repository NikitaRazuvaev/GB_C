// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Caclpow(int A, int B)
{
    int p = A;
    for (int i = 1; i < B; i++)
    {
        p = p * A;
    }
    return p;
}

Console.Clear();

Console.Write("Введите число A: ");
int inputnumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int inputnumberB = int.Parse(Console.ReadLine());

Console.Write(Caclpow(inputnumberA,inputnumberB));

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число 1: ");
int N = int.Parse(Console.ReadLine());
Console.Write(N.ToString()+ "->");
for (int i = 2; i <=N; i= i+2)
{
            Console.Write(i.ToString()+  ",  ");
}




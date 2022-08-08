// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int numberC = int.Parse(Console.ReadLine());
if (numberA < numberB){ Console.WriteLine(numberB.ToString());}
else{ if (numberB < numberC){ Console.WriteLine(numberC.ToString());}
if (numberC < numberA){ Console.WriteLine(numberA.ToString());}}

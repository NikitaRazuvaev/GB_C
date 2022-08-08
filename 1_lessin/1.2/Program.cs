// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.(Пример:a = 5; b = 7 -> max = 7)
Console.WriteLine("Введите число a");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{ Console.WriteLine(numberA.ToString());}
else
{ Console.WriteLine(numberB.ToString());}

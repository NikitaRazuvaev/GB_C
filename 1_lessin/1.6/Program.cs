// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
 int numberA = int.Parse(Console.ReadLine());
if (numberA %2 == 0 )
{
    Console.WriteLine("четное число");
    Console.WriteLine(numberA);
}
else { 
    Console.WriteLine("нечетное число");
    Console.WriteLine(numberA);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (number.Length >= 3)
{
    Console.Write(number[2]);
}
else
{
    Console.Write("Нет 3-го числа");
}

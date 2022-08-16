// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Int16.Parse(input);
if (number >= 6 ) {
    Console.Write( "да");
}
else {
    Console.Write("Нет");
}

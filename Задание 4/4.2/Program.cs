//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getsumofdigets(string input)
{

    int sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int n = int.Parse(input[i].ToString());
        sum += n;
    }
    return sum;
}


Console.Clear();

Console.Write("Введите число: ");
string inputnumber = Console.ReadLine();


Console.Write($"Вывод: {getsumofdigets(inputnumber)} ");

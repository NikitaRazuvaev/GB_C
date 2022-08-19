//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void CheckingNumbers(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else
    {
        Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
}


Console.Clear();

int num = -1;
while (num < 0)
{
    try
    {
        Console.WriteLine("Введите пятизначное число:");
        num = int.Parse(Console.ReadLine());
        if (num < 10000 || num > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            num = -1;
        }
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        num = -1;
    }


}

CheckingNumbers(num.ToString());



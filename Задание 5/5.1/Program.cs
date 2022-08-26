/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Random rnd = new Random();

Console.Clear();

int [] CreadteArray(int count)
{
    int [] Rezult = new int [count];
    for(int i = 0; i < count; i++)
    {
        Rezult[i] = 100 + rnd.Next(900);
    }
    return Rezult;

}

int  CountOdd(int [] erray)
{
    int count = 0;
    for (int i = 0; i < erray.Count(); i++ )
    {
        if (erray[i] % 2 == 0 )
        {
            count++;
        }
        
    }
    return count;
}  

void PrintArray(int [] erray)
{

    Console.Write("[");
    for (int i = 0; i < erray.Count(); i++)
    {
        Console.Write(erray[i]);
        if (i < erray.Count() - 1)
        {
            Console.Write(", ");
        }
    }
     Console.Write("]");
}


int [] randomdata = CreadteArray(20);
PrintArray(randomdata);
Console.Write($"Вывод: {CountOdd(randomdata)} ");
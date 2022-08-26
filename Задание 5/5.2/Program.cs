/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/
Random rnd = new Random();

Console.Clear();

int [] CreadteArray(int count)
{
    int [] Rezult = new int [count];
    for(int i = 0; i < count; i++)
    {
        Rezult[i] = rnd.Next(2000) - 1000;
    }
    return Rezult;

}

int  CountMyNun(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Count(); i++ )
    {
        if (array[i] % 2 == 1 )
        {
            count += array[i];
        }
        
    }
    return count;
}  

void PrintArray(int [] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Count(); i++)
    {
        Console.Write(array[i]);
        if (i < array.Count() - 1)
        {
            Console.Write(", ");
        }
    }
     Console.Write("]");
}


int [] randomdata = CreadteArray(20);
PrintArray(randomdata);
Console.Write($"Вывод: {CountMyNun(randomdata)} ");
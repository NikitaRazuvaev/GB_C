
Console.Clear();

Random random = new Random();

int[,]arrary = new int[random.Next(1, 5), random.Next(1, 5)];
for (int i = 0; i < arrary.GetLength(0); i++)
{
    for (int j = 0; j < arrary.GetLength(1); j++)
    {
        arrary[i, j] = random.Next(1,10);
        Console.Write(arrary[i, j] + " ");
    
    }
    Console.WriteLine();
}
Console.WriteLine("Результат:"); 


for (int j = 0; j < arrary.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrary.GetLength(0); i++)
    {
        sum += arrary[i,j];
    }

     Console.Write($" {sum / arrary.GetLength(0)}");

}
Console.WriteLine();




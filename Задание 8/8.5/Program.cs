/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

int[,] ArrayX = new int[4, 4];
int limit = (ArrayX.GetLength(0) + 1) * (ArrayX.GetLength(1) + 1);
int i = 0;
int j = 0;
int d = 0;
int imin = -1;
int imax = ArrayX.GetLength(0);
int jmin = -1;
int jmax = ArrayX.GetLength(1);
for (int c = 1; c <=  limit; c++)
{
    ArrayX[i, j] = c;

    switch (d)
    {
        case 0:
            {
                if (j + 1 >= jmax)
                {
                    d = 1;
                    imin = i;
                    i++;
                }
                else
                {
                    j++;
                }
            };
            break;
        case 1:
            {
                if (i + 1 >= imax)
                {
                    d = 2;
                    jmax = j;
                    j--;
                }
                else
                {
                    i++;
                }
            };
            break;
                case 2:
            {
                if (j-1 >= jmin)
                {
                    d = 3;
                    imax = i; 
                    i--;      
                }
                else
                {
                    j--;
                }
            };
            break;
            case 3:
            {
                if (i-1 >= imin)
                {
                    d = 0;
                    jmin = j; 
                    j++;      
                }
                else
                {
                    i--;
                }
            };
            break;
    }
    PrintArray(ArrayX);
}



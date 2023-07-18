/*
Найдите сумму элементов , находящихся на главной диагонали 
с индексами (0,0) (1,1) (2,2)
*/
int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SunOfDioganalsElemets(int[,] matrix)
{
    int sunOfDioganalsElemets = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sunOfDioganalsElemets += matrix[i, j];
            }
        }
    }
    return sunOfDioganalsElemets;
}

int[,] numbers = GetRandom2DArray(5, 4, 10);
Print2DArray(numbers);
Console.WriteLine($"сумма диагональных элементов = {SunOfDioganalsElemets(numbers)}");

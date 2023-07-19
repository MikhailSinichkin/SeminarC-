/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetRandom2dArray(int rows, int columns, int deviation)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
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

double[] Average(int[,] array)
{
    double[] sumInArray = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumInArray[i] += array[j, i];
           
        }
         sumInArray[i] /= array.GetLength(0);
    }
    return sumInArray;

}

void PrintAverage(double[] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} \t ");

    }
    
}






int[,] matrix = GetRandom2dArray(5, 5, 10);
Print2DArray(matrix);
System.Console.WriteLine();
double[] newArray = Average(matrix);
System.Console.WriteLine($" среднее арифметическое элементов в каждом столбце :");
PrintAverage(newArray );


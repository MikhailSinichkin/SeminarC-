/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] GetRandom2dArray = new int[4, 4];

int value = 1;
int rowStart = 0;
int rowEnd = GetRandom2dArray.GetLength(0) - 1 ;
int colStart = 0;
int colEnd = GetRandom2dArray.GetLength(1) - 1 ;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        GetRandom2dArray[rowStart, i] = value;
        value++;
    }
    rowStart++;
    for (int i = rowStart; i <= rowEnd; i++)
    {
        GetRandom2dArray[i, colEnd] = value;
        value++;
    }
    colEnd--;
    for (int i = colEnd; i >= colStart; i--)
    {
        GetRandom2dArray[rowEnd, i] = value;
        value++;
    }
    rowEnd--;
    for (int i = rowEnd; i >= rowStart; i--)
    {
        GetRandom2dArray[i, colStart] = value;
        value++;
    }
    colStart++;
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
Print2DArray(GetRandom2dArray);
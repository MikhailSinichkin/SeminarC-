/*53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Валерия 13:01
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
*/

int[,] GetRandom2dArray(int rows, int columns, int deviation)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
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


void ReversMatrix(int[,] matrix)
{
    int len = matrix.GetLength(1);
    for (int i = 0; i < len; i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] matrix = GetRandom2dArray(4,4,10);
Print2DArray (matrix);
Console.WriteLine();
ReversMatrix(matrix);
Print2DArray (matrix);








/*int[,] getRandMatrix(int rows, int columns, int deviation)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(-deviation, deviation + 1);
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    Console.Write("[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
        Console.Write($"[{i + 1}]" + "\t");

    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i + 1}]" + "\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void reverseMatrix(int[,] matrix)
{
    int rowLen = matrix.GetLength(1);
    int lastRow = matrix.GetLength(0) - 1;
    for(int i = 0; i < rowLen; i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}

int[,] mtr = getRandMatrix(5, 7,
void reverseMatrix(int[,] matrix)
{
    int rowLen = matrix.GetLength(1);
    int lastRow = matrix.GetLength(0) - 1;
    for(int i = 0; i < rowLen; i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}

int[,] mtr = getRandMatrix(5, 7, 10);
printMatrix(mtr);
Console.WriteLine();
reverseMatrix(mtr);
printMatrix(mtr);*/
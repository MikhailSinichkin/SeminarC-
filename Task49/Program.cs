﻿/*
49. задайте двумерный массив. Найдите элементы ,
у которых оба индекса четные , и замените эти элементы на их квадраты,
Например изначально массив выглядит так :
1 4 7 2 
5 9 2 3 
8 4 2 4 
Новый массив будет выглядить так :
1 4 7 2 
5 81 2 9 
*/
int[,] Get2DArray(int rowNumber, int colNumber, int deviation)
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

int[,] numbers = Get2DArray(3, 4, 10);
Print2DArray(numbers);
Console.WriteLine();
void ChangeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
}

ChangeMatrix(numbers);
Print2DArray(numbers);
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] getRandomArray(int length )
{
    int [] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

void printArray (int[] arrayToPrint)
{
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;
}


int [] randomArray = getRandomArray(8);
printArray(randomArray);
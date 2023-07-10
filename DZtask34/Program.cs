/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] getRandomArray(int length )
{
    int [] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
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




int CalcEventNumbers(int[] randomArray)
{
    int count = 0;
    for(int i = 0; i < randomArray.Length; i++)
    {
        if(randomArray[i] % 2 == 0)
            count++;
    }

    return count;
}
int [] randomArray = getRandomArray(5);
printArray(randomArray);

Console.WriteLine($"\nКол-во четных чисел - {CalcEventNumbers(randomArray)}");



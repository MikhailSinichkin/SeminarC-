/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] getRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-99,100);
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
    
}

int SumOdd(int[] array)
{
    int sum = 0;
    for ( int i = 1; i < array.Length; i+=2) 
    {
        sum = sum + array[i]; 
    }
    return sum;
}
int [] randomArray = getRandomArray(6);
printArray(randomArray);

Console.WriteLine($"Сумма элементов нечетных позиций- {SumOdd(randomArray)}");
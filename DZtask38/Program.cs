/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] getRandomDoubleArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble();
        
    }
    return result;
}

void printArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length-1)
        {
            Console.Write(" , ");
        }
    }
    Console.WriteLine("]");
}

double [] randomArray = getRandomDoubleArray(6);
printArray(randomArray);

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] getRandomDoubleArray(int length)
{
    double[] result = new double[length];
    double minValue = 0.0;
    double maxValue = 100;
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        result[i] = Math.Round(result[i], 2);

    }
    return result;
}

void printArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(" , ");
        }
    }
    Console.WriteLine("]");
}

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }
    return max;

}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] randomArray = getRandomDoubleArray(6);
printArray(randomArray);
Console.WriteLine($"максимум-{FindMax(randomArray)}");
Console.WriteLine($"минимум-{FindMin(randomArray)}");
Console.WriteLine($"разница-{FindMax(randomArray) - FindMin(randomArray)}");
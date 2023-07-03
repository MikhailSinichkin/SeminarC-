/*30. # Напишите программу,
 которая выводит массив из 8 элементов, 
 заполненный нулями и единицами в случайном порядке.
 */
    //foreach (int i in array)-та же конфетка 

 int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
int[] array = FillArray(8);
foreach(int i in array)
{
    System.Console.Write($"{i} ");
}
System.Console.WriteLine();

/*
void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]); 
        if (i < array.Length - 1) 
        {
            Console.Write(", "); 
        }
    }
    Console.Write("]");
} 
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2);
}

PrintArray(array);*/

/*решение от Макса*void fillRandomArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] randomArray = new int[8];
fillRandomArray(randomArray);
printArray(randomArray);*/
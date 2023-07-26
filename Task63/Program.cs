/*
Задайте значение N. Напишите программу ,
 которая выдает все натуральные чтсла в промежутке от 1 да N.
*/

void NaturaleNumbers(int number, int count = 1)
{
    if (number < count)

    return;
    else
    {
        Console.Write(count+ " " );
        NaturaleNumbers(number,count+1);
    }
}
NaturaleNumbers(5);
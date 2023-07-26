/*
Задайте значение N. Напишите программу ,
которая выведет все натуральные числа в промежутке от M до N.
*/

void NaturaleNumbers(int number1, int number2 )
{
    if (number1 <= number2)
    {
        Console.Write(number1+ " " );
        NaturaleNumbers(number1+1,number2);
    }
}
NaturaleNumbers(4,8);
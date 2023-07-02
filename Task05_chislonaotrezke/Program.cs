/*Напииште программу , которая выводит случайное число из
отрезка [10,99] и показывает наибольшую цифру числа.
например 
78->8
12->2
85->8
*/

int rundomNumber = new Random().Next(10,100);
Console.WriteLine($"РАндомное число - {rundomNumber}");

int numberOne = rundomNumber % 10;
int numberTwo = rundomNumber / 10;
Console.Write($" У числа  - {rundomNumber} большая цифра ");

if (numberOne > numberTwo)
{
    Console.Write(numberOne);
}
else
{
    Console.Write(numberTwo);
}
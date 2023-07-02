/*
Напишите программу , которая выводит трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int numberRundom = new Random().Next(100, 1000);


int numberTwo = numberRundom % 10;
int numberThree = numberRundom / 100;

int result = numberThree*10 + numberTwo;
Console.WriteLine($"РАндомное число - {numberRundom}");
Console.WriteLine($" Наше решение - {result}");
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру ");
int num = Convert.ToInt32(Console.ReadLine());

start:
if (num > 7 || num <1) 
{
    Console.WriteLine($"{num} Выбери день меньше 8");
    num = Convert.ToInt32(Console.ReadLine());
    goto start;
}
if (num > 5)
{
    Console.WriteLine("Да - Выходной");
}
else if (num < 6)
{
    Console.WriteLine("Нет - Будний");
}
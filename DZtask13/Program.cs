/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

start:
if (num < 99)
{
    Console.WriteLine($"{num} - третьей цифры нет!");
    num = Convert.ToInt32(Console.ReadLine());
    goto start;
}
while (num >= 1000)
{
    num = num / 10;
}
 int result = num % 10;
 Console.WriteLine($"третья цыфра в вашем числе {result}");
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
start:
if (num < 10000 || num > 99999)
{
    System.Console.WriteLine("Введите пятизначное число");
    num = Convert.ToInt32(Console.ReadLine());
    goto start;
}

 else if (num % 10 == num / 10000 && num / 10 % 10 == num / 1000 % 10)
{
    System.Console.WriteLine($" {num} - палиндром");
} 
System.Console.WriteLine($" {num} - не палиндром");




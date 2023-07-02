/*
Напишите программу , которая принимает на вход два числа и проверяет ,
является ли одно квадратом другого.
5 , 25-> да
-4 , 16 ->да
25 , 5 -> да
8 , 9 -> нет
*/

Console.Write("введите первое число- ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число- ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ((num1 * num1 == num2) || (num2 * num2 == num1)) Console.WriteLine("да");
else Console.WriteLine("нет");
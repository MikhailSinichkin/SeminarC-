/*
Напишите программу, которая на вход принимает два числа
и проверяет , является ли первое число квадратом второго
a = 25 ; b = 5 -> yes
a = 2 ; b = 10 -> no
a = 9 ; b = 3 -> yes
a = -3 ; b = 9 -> no
*/

Console.WriteLine("Введите число №1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
bool result;
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2) result = true ;

else result = false;
 Console.WriteLine(result);

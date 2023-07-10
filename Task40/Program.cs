/*40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

Console.WriteLine("Введите число №1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && c + a > b && b + c > a) Console.WriteLine ("Да , может существоватью");
else
 Console.WriteLine ("нет , может существоватью");

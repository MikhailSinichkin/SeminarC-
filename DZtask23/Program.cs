/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

string cube(int n)
{
    string cube = "0";
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            cube = $"{cube} {i * i * i}";
        }
    }
    else
    {
        for (int i = -1; i >= n; i--)
        {
            cube = $"{cube} {i * i * i}";
        }
    }
    return cube;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(cube(number));
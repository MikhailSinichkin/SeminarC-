/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int recSum(int m, int n)
{
    if (m >= n)
    {
        return m;
    }
    else
    {
        return recSum(m + 1, n) + m;
    }
}

System.Console.WriteLine(recSum(1, 15));
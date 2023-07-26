﻿/*
Доп
Напишите программу, 
которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

void Sum(int num1, int num2, int N)
{
    if (N > 0)
    {
        System.Console.Write(num1 + " ");
       
        int sum = num2 + num1;
        num1 = num2;
        num2 = sum;
        Sum(num1, num2, N - 1);

    }
}
Sum(3, 4, 5);

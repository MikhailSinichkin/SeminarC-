/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int mult = 0;

while (count <= Num )
    {
        mult = count * count * count;
        count += 1;
        Console.WriteLine($"{mult} ");
    }




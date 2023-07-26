/*
Напишите программу , которая на вход принимает А и В ,
и возводит число А в целую степень В с помощью рекурсии.
*/

int ATiPowB(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * ATiPowB(a, b - 1);
    }
}
System.Console.WriteLine(ATiPowB(2, 9));
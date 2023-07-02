/*
Напишите программу , которая принимает на вход число (N)
и выдаеттаблицу квадратов чисел от 1 до N.
*/

string Squares(int n)
{
    string Squares = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)
        {
            Squares = $"{Squares} {i * i}";
        }
    }
    else
    {
        for (int i = 0; i >= n; i--)
        {
            Squares = $"{Squares} {i * i}";
        }
    }
    return Squares;
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Squares(number));
/*
Задача на проверку в папке DZtask23NOString . Это я решал для положительных и отрицательных чисел от 0 до N. 
*/
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (n > 0)

{
        for (int i = 1; i <= n; i++)
        {
            number = i * i * i;
            Console.Write($"{number}  ");
        }
}
else
{
    for (int i = -1; i >= n; i--)
    {
        number = i * i * i;
        Console.Write($"{number}  ");
    }
}


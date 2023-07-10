/*44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 1;
int fibi = 0;
Console.Write(number1 + " ");
Console.Write(number2 + " ");
for (int i = 0; i < number-2; i++)
{
    fibi = number1 + number2;
    Console.Write(fibi + " ");
    number1 = number2;
    number2 = fibi;
}


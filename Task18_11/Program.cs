/* Напишите программу , которая по заданному номеру четверти,
показывает диапозон вводимых координат в точках в этой четверти ( Х и У).
*/

 Console.WriteLine("Введи номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());

void GetQuarter(int quarter) 
{

if (quarter == 1)
{
    Console.WriteLine($"X and Y > 0");

}
else if (quarter == 2)
{
    Console.WriteLine($" X < 0 and Y > 0");

}
else if (quarter == 3)
{
    Console.WriteLine($" X < 0 and Y < 0");

}
else if (quarter == 2)
{
    Console.WriteLine($" X > 0 and Y < 0");

}
}
 GetQuarter(number);
/*42. Напишите программу, которая будет преобразовывать десятичное число в 
двоичное.

Валерия Geek Brains 14:05
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число №1");
int dicimal = Convert.ToInt32(Console.ReadLine());

int count = 1;
int binary = 0;
while (dicimal > 0)
{
    binary = binary + dicimal % 2 * count;
    count = count * 10;
    dicimal = dicimal / 2;
}

Console.WriteLine(binary);
/*
Напишите программу , которая принимает на вход координаты точки (x<y),
причем х и y не равны нулю и выдает номер четверти плоскости , в которой находится эта точка.
*/

int GetNumberofQuarter(int X, int Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    if (X < 0 && Y < 0)
    {
        result = 3;
    }
    if (X > 0 && Y < 0)
    {
        result = 4;
    }
    return result;
}

Console.WriteLine("Введи переменную X ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи переменную Y ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberofQuarter(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"точка [{userX} : {userY}] находится в {quarter}плоскости ");

}
else
{
    Console.WriteLine($"точка [{userX} : {userY}] находится на пересечении плоскостей ");
}

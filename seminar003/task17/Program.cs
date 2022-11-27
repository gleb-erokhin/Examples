// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите х ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine($"Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine($"Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine($"Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine($"четвертая четверть");
}
else
{
    Console.WriteLine($"Ноль в координатах");
}

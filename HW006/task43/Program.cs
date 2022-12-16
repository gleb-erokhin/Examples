// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCross(float k1, float k2, float b1, float b2)
{
    float x = 0;
    float y = 0;
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые паралельны");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else
    {
        x = (b1 - b2) / (k2 - k1);
        y = k1 * (b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"Координаты пересечения прямых ({x}; {y})");
    }
    
}

FindCross(5, 9, 2, 4);


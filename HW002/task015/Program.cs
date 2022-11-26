// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine($"Введите день недели ");
int Num_day = Convert.ToInt32(Console.ReadLine());
if (Num_day >= 6)
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}
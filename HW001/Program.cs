// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите число А ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA > numB)
// {
//     Console.WriteLine($"max = {numA}");
// }
// else
// {
//     Console.WriteLine($"max = {numB}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число А ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB && numA > numC)
{
    Console.WriteLine($"max = {numA}");
}
else if (numB > numA && numB > numC)
{
    Console.WriteLine($"max = {numB}");
}
else
{
    Console.WriteLine($"max = {numC}");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
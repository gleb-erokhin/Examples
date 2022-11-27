// 22) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите целое натуральное число: ");
double N = Convert.ToDouble(Console.ReadLine());
if(N > 0 && (N*10) % 10 == 0)
{
    for(int i = 1; i <= N; i++) Console.Write($"{i*i} ");
}
else Console.Write($"Просили же ввести целое натуральное число");



// ++++++ второй вариант +++++

// using System;
// using static System.Console;

// WriteLine("Введите число");
// int N = Convert.ToInt32(ReadLine());

// int count = 1;
// while(count < N)
// {
//     Write($"{Math.Pow(count, 2)}, ");
//     count++;
// }
// Write($"{Math.Pow(count, 2)}");

// ++++3 вариант++++

// Console.Write($"Введите число N: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= a; i++)
// {
//     Console.Write($"{Math.Pow(i, 2)}, ");
// }

﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arayRandom()
{
    int[] array = new int[8];
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(1, 50);
        i++; 
    }
    return array;
}

int[] x = arayRandom();

for (int i = 0; i < x.Length; i++)
Console.Write($"{x[i]}, ");



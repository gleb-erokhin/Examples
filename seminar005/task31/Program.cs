﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве 

int[] arrRand(int len)
{
    int[] a = new int[len];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-10, 10);
    }
    return a;
}

int len = 12;
int[] arr = new int[len];
int sumPlus = 0;


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// using System;
// using static System.Console;

// Clear();

// Write("Введите размер массива: ");
// int size = int.Parse(ReadLine());
// int[] array = fillArray(size, 0, 1000);
// WriteLine($"[{String.Join(",", array)}]");
// Write(findNumbArray(array, 10, 99));



// int[] fillArray(int size, int minValue, int maxValue) //заполнение массива
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }


//     return array;

// }

// int findNumbArray(int[] array, int left, int right)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= left && array[i] <= right)
//         {
//             result++;
//         }
//     }
//     return result;
// }

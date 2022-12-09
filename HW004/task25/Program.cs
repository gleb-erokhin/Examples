﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void printPOW(int num1, int num2)
{
    int result = 1;
    int i = 1;
    //Пока счетчик не <= переменной степени выполняем цикл  
    while (i <= num2)
    {
        result = result * num1; // результату присваеваем значение результата умноженного на само число A
        i++;                    // увеличиваем счетчик на итерации 
    }
    // выводим результат
    Console.WriteLine(result);
} 

printPOW(2, 18);

// -------------------

// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// // инициализируем результирующую переменную, и счетчик
// int result = 1;
// int i = 1;
// //Пока счетчик не <= переменной степени выполняем цикл  
// while (i <= num2)
// {
//     result = result * num1; // результату присваеваем значение результата умноженного на само число A
//     i++;                    // увеличиваем счетчик на итерации 
// }
// // выводим результат
// Console.WriteLine(result);
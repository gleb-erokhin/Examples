// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] num =  new int {};

Console.WriteLine("Введите число ");
num = Convert.ToInt32(Console.ReadLine());

foreach (int n in num)
{
    Console.WriteLine(n);
}



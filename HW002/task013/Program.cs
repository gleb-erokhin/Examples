// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num % 10;
// Console.WriteLine(result);


int n = 78;
while (n > 1000) n /= 10;
Console.WriteLine($"{n % 10}");



// int n = Convert.ToInt32(Console.ReadLine());

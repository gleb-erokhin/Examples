// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
string num = Convert.ToString(Console.ReadLine());

if(num[0] == num[num.Length - 1] && num[1] == num[num.Length-2])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}








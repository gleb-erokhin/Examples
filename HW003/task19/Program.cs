// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// +++ решение через строки +++

// Console.WriteLine("(Через строки) Введите число ");
// string num = Console.ReadLine()?? String.Empty;

// if(num[0] == num[num.Length - 1] && num[1] == num[num.Length-2])
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// +++ решение через массив +++

// int[] a = new int[5];
// Console.WriteLine("(Через массив) Введите число ");
// int sub_num = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// while(sub_num > 0)
// {
//     a[i] = sub_num % 10;
//     sub_num = sub_num / 10;
//     // Console.Write(a[i]);
//     i++;
// }

// if (a[0] == a[^1] && a[1] == a[^2])
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// +++ решение через массив +++

Console.WriteLine("(Через массив) Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
// решение через развернуть число
int result = 0;
int newNum = num;
while (newNum > 0)
{
    // получаем последнюю цифру, и прибавляем к десятку
    result = result * 10 + newNum % 10;
    newNum /= 10;
}
// сравниваем resul и num
if (result == num)
{
    Console.WriteLine("полиндром");
}
else
{
    Console.WriteLine("не полиндром");
}
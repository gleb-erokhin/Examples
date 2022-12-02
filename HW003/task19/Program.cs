// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int[] num =  new int[1];

// Console.WriteLine("Введите число ");
// num[0] = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
while(num > 0)
{
    int digit = num % 10;
    num /= 10;
    num2 = num2 * 10 + digit; 
}

num /= 1000;
num2 /= 1000;
Console.WriteLine($"начальное число {num}");
Console.WriteLine($"измененное число {num2}");
if (num == num2)
{

    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}





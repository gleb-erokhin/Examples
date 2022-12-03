// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int num)
{
    int i = 0;
    while(i < num)
    {
        num = num / 10;
        i++;
    }
    return i;
}

int x = Convert.ToInt32(Console.ReadLine());
int answer = Count(x);
Console.WriteLine(answer);
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Count(int num)
{
    int mult = 1;
    int i = 1;
    while(i <= num)
    {
        mult = mult * i;
        i++;
    }
    return mult;
}

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int answer = Count(x);
Console.WriteLine(answer);
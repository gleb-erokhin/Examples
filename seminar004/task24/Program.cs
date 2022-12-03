// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Num(int A)
{
    int i = 1;
    int sum = 0;
    while(i <= A)
    {
        sum = sum + i;
        i++;
    }
    return sum;
}

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int answer = Num(x);
Console.WriteLine(answer);

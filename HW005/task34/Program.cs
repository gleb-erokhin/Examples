// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arayRandom()
{
    int[] array = new int[4];
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(100, 1000);
        i++; 
    }
    return array;
}

int ShowNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] x = arayRandom();

// посмотреть урок преподавателя по поводу метода принт
for (int i = 0; i < x.Length; i++)
Console.Write($"{x[i]}, ");

Console.WriteLine();

int y = ShowNum(x);
Console.WriteLine($"Четных чисел в массиве = {y}");
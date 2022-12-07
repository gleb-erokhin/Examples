// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// создаем метод принимающий количество элементов массива и возвращающий созданный массив
int[] arayRandom(int data)
{
    int[] array = new int[data];
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(100, 1000);
        i++; 
    }
    return array;
}

// Создаем метод принимающий в аргумент массив, и возвращающий количество в нем четных чисел
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

// Метод производит печать созданного массива
void PrintData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
}

// запрос размера массива
Console.WriteLine("Введите размер массива ");
int arrayRange = Convert.ToInt32(Console.ReadLine());

// вызываем методы
int[] x = arayRandom(arrayRange); // запрашиваем размер массива
PrintData(x);
int y = ShowNum(x);
Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве = {y}");

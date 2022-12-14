// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// создаем метод принимающий количество элементов массива и возвращающий созданный массив
int[] arayRandom(int data)
{
    int[] array = new int[data];
    int i = 0;
    while(i < array.Length)
    {
        // наполняем массив по индексу случайным 3х значным значением в каждой итерации
        array[i] = new Random().Next(-100, 100); 
        // увеличиваем счетчик
        i++; 
    }
    return array; // возвращаем массив
}

// метод получает на вход массив и скрадывает элементы на нечетной позиции
int SumNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
            i++;
        }
    }
    return sum;
}

// Метод производит печать созданного массива
void PrintData(int[] arr)
{
    // проходим по массиву и выводим его в строку для видимости данных
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
}

// запрос размера массива от пользователя
Console.WriteLine("Введите размер массива ");
int arrayRange = Convert.ToInt32(Console.ReadLine());

// вызываем методы
int[] x = arayRandom(arrayRange); // воод аргумента с размером массива
PrintData(x);                     // печатаем случайный массив
int y = SumNum(x);                // подаем массив на вход метода для суммирования элем. нечетной позиции
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетной позиции в массиве = {y}");  // выводим сумму элементов

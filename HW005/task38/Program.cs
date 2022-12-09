// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// создаем метод принимающий количество элементов массива и возвращающий созданный массив
double[] arayRandomDouble(int data)
{
    // создается один генератор случайных чисел c вызовом метода NextDouble
    Random rand = new Random();
    double[] array = new double[data];
        // Store random floating point 
        // numbers in the array
    for (int i = 0; i < data; i++)
        // сохранаяем случайное значение элемента в массив
        array[i] = rand.NextDouble();
    return array; // возвращаем массив
}

double[] MaxMin(double[] input)
{
    int count = 0; // счетчик четных чисел
    for (int i = 0; i < input.Length; i++) // проходим по элементам массива 
    {
        if (array[i] % 2 == 0) // проверяем элемент на четность
        {
            count++; // если true увеличиваем на 1
        }
    }
    return count; // возвращаем количество четных элементов
}
// Метод производит печать созданного массива
void PrintData(double[] arr)
{
    // проходим по массиву и выводим его в строку для видимости данных
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
}

// запрос размера массива от пользователя
Console.WriteLine("Введите размер массива ");
int arrayRange = Convert.ToInt32(Console.ReadLine());

// вызываем методы
double[] arrayDoubleData = arayRandomDouble(arrayRange);    // воод аргумента с размером массива
PrintData(arrayDoubleData);                                 // печатаем случайный массив
// int y = SumNum(x);                           // подаем массив на вход метода для суммирования элем. нечетной позиции
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов на нечетной позиции в массиве = {y}");  // выводим сумму элементов
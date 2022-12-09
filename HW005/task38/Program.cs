// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// создаем метод принимающий количество элементов массива и возвращающий созданный массив
double[] arayRandomDouble(int data)
{
    // создается один генератор случайных чисел c вызовом метода NextDouble
    Random rand = new Random();
    double[] array = new double[data];
    for (int i = 0; i < data; i++)
    // сохранаяем случайное значение элемента в массив
        array[i] = Math.Round(rand.NextDouble(), 5);
    return array; // возвращаем массив
}

double MaxMin(double[] input)
{
    double max = input[0];
    double min = input[0];
    for (int i = 0; i < input.Length; i++) // проходим по элементам массива 
    {
        if (input[i] > max) max = input[i];  // проверяем элемент на четность
        else if (input[i] < min) min = input[i];
    }
    return (max - min);
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
double answer = MaxMin(arrayDoubleData);
Console.WriteLine($"Разница равна между max и min {Math.Round(answer, 5)}");

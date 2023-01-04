// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[] ArraySumm(int[,] array)
{
    int[] summ = new int[4];

    for(int row = 0; row < array.GetLength(0); row++)
    {
        int sum = 0;
        for(int col = 0; col < array.GetLength(1); col++)
        {
            sum = sum + array[row, col];
            // Console.WriteLine($"row = [{row}], col = [{col}], sum - {sum}, array - {array[row, col]}");
            // Вывод в консоль для тестирования
        }
        summ[row] = sum;
        // Console.WriteLine();
        // Console.WriteLine($"summ - {summ[row]}");
        //  вывод в консоль для тестирования
    }
    return summ;
}


void AnswerLine(int[] a)
{
    int min = a[0];
    int index = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] < min)
        {
            min = a[i];
            index = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index + 1} строка");
}

void PrintSumm(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    Console.Write($" {a[i]} ");
}

// ------ Обращение к методу --------

int[,] array = {{8, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

// Получаем одномерный массив с суммой строк
int[] x = ArraySumm(array);

// Вычисляем строку с наименьшей суммой и выводим на экран
AnswerLine(x);

Console.WriteLine();
Console.WriteLine("Массив с суммой строк: ");
// Печатаем массив для сравнения
PrintSumm(x);










// Console.WriteLine();
// for(int i = 0; i < summ.Length; i++)
// Console.Write($" {summ[i]} ");


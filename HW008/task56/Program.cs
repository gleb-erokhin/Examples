// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] RandomArray(int a, int b)  // метод создания случайного двумерного массива
{
    int[,] rand = new int[a, b];
    for(int row = 0; row < rand.GetLength(0); row++)
    {
        for(int col = 0; col < rand.GetLength(1); col++)
        {
            rand[row, col] = new Random().Next(1, 10);
        }
    }
    return rand;
}


int[] ArraySumm(int[,] array, int n)  // На вход метода подаем слуяайный двумерный массив и количество строк в массиве, получаем одномерный массив с суммами строк.
{
    int[] summ = new int[n];

    for(int row = 0; row < array.GetLength(0); row++)
    {
        int sum = 0;
        for(int col = 0; col < array.GetLength(1); col++)
        {
            // суммируем каждый элемент строки
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


void AnswerLine(int[] a)  // вычисляем минимальный элемент в массиве и его индекс
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

void PrintSumm(int[] a)  // печать одномерного массива с суммами для сравнения и отладки
{
    for(int i = 0; i < a.Length; i++)
    Console.Write($" {a[i]} ");
}

// ------ Обращение к методу --------

// Вводим количество строк и столбцов
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

// Вводим значения в метод для создания случайного двумерного массива и печатаем его
int[,] x = RandomArray(n, m);


// Получаем одномерный массив с суммой строк, дополнительно передаем количество строк
int[] y = ArraySumm(x, n);

// Вычисляем строку с наименьшей суммой и выводим на экран
AnswerLine(y);

// Печатаем массив для сравнения
Console.WriteLine();
Console.WriteLine("Массив с суммой строк: ");
PrintSumm(y);










// Console.WriteLine();
// for(int i = 0; i < summ.Length; i++)
// Console.Write($" {summ[i]} ");


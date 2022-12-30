// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArraySort(int[,] array)  // метод пузырьковой сортировки двумерного массива от большого к меньшему
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            for(int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if(array[row, i] < array[row, i + 1])
                {
                    int k = array[row, i];
                    array[row, i] = array[row, i +1];
                    array[row, i + 1] = k;
                }
            }
        }
    }
    return array;
}


void printArr(int[,] a)  // метод печати двумерного массива
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Вводим количество строк и столбцов
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

// Вводим значения в метод для создания случайного двумерного массива и печатаем его
int[,] x = RandomArray(n, m);
Console.WriteLine("Исходный массив: ");
printArr(x);

// Добавляем в метод для сотировки и печатаем вывод
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
int[,] y = ArraySort(x);
printArr(y);
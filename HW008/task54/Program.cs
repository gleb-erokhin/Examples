// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
// int[,] temp = new int[1, 1];
// for(int row = 0; row < array.GetLength(0); row++)
// {
//     for(int col = 0; col < array.GetLength(1); col++)
//     {
//         if(array[row, col] > array[row, col + 1])
//         {
//             int k = array[row, col];
//             array[row, col] = array[row, col + 1];
//             array[row, col + 1] = k;
//         }
//     }
//     // Console.WriteLine();
// }

for(int row = 0; row < array.GetLength(0); row++)
{
    for(int col = 0; col < array.GetLength(1); col++)
    {
        for(int i = 0; i < array.GetLength(1) - 1; i++)
        {
            // Console.WriteLine($"(row {row}, col {col})  = {array[row, col]}");
            if(array[row, col] > array[row, col + 1])
            {
                int k = array[row, col];
                array[row, col] = array[row, col +1];
                array[row, col + 1] = k;
            }
        }
        // Console.WriteLine($"(row {row}, col + 1 {col + 1}) = {array[row, col + 1]}");
        // if(array[row, col] > array[row, col + 1])
        // {
        //     Console.WriteLine($"col {array[row, col]}");
        //     Console.WriteLine($"col + 1 {array[row, col + 1]}");
        // }
    }
    // Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)  // подсчет размерности массива через метод, (0) в скобках ссылается на строку 12 int[3, 4]
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

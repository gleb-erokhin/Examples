// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] array = {{3,4,7,2}, {5,12,2,3}, {8,4,22,4}};

PrintArray(array);
Console.WriteLine(ModifyArray(array));

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int ModifyArray(int[,] value)
{
    int count = 0;
    // 
    int x = Math.Min(array.GetLength(0), array.GetLength(1));
    for (int i = 0; i < x; i++)  
    {
        count += value[i, i];
    }
    return count;
}


























// int[,] FillArray();

// int[,] array = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

// {
//     for (int i = 0; i < array.GetLength(0); i++)  // подсчет размерности массива через метод, (0) в скобках ссылается на строку 12 int[3, 4]
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,]  FillArray();





        // if (i % 2 ==0 && j % 2 ==0)
        // {
        //     array[i, j] *= array[i, j];
        // }
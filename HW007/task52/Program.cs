// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arrRand()
{
    int[,] a = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} };
    
    // int[,] a = new int[3,4];
    // for (int i = 0; i < a.GetLength(0); i++)
    // {
    //     for (int j = 0; j < a.GetLength(1); j++)
    //     {
    //         a[i,j] = new Random().Next(1, 10); 
    //     }
    // }
    return a;
}

void Average(int[,] a)
{
  int[] sum = new int[4];
  for (int i = 0; i < a.GetLength(0); i++)
  {
      for (int j = 0; j < a.GetLength(1); j++)
        {
          
          Console.WriteLine($"before {i}");
          Console.WriteLine($"before {j}");
          sum[i] += a[j, i];
          Console.WriteLine($"after {i}");
          Console.WriteLine($"after {j}");

        }
        Console.WriteLine();
  }
  Console.WriteLine();
  foreach(float s in sum)
  {
    Console.WriteLine(s / 4);
  }
  
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] x = arrRand();
PrintArray(x);
// float[] y = Average(x);
Average(x);
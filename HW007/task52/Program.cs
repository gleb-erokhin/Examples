// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arrRand()
{
    int[,] a = new int[3,4];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(1, 10); 
        }
    }
    return a;
}

int[,] Average(int[,] a)
{
  int[] b = new int[4];
  int sum = 0;
  int 
  for (int j = 0; j < a.GetLength(1); j++)
  {
      for (int i = 0; i < a.GetLength(1); i++)
        {
          sum = sum + a[j,i];
        }
        b[i] = sum / j;
  }
  return b;
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

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


float[,] arrRand()
{
    float[,] a = new float[3,4];
    Random rand = new Random();
    float min = -10;
    float max = 10;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            float randomFloat = (float)rand.NextDouble();
            a[i,j] = (randomFloat * (max - min)) + min;
        }
    }
    return a;
}


void PrintArray(float[,] array)
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

float[,] x = arrRand();
PrintArray(x);
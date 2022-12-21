// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] arrRand() // создание двумерного массива с целыми случайными числами
{
    int[,] a = new int[2,2];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(1, 10); 
        }
    }
    return a;
}

void PrintArray(int[,] array) // печать массива
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

void Division(int[,] a, int[,] b)
{
    int[,] div = new int[2,2];
    div[0, 0] = a[0, 0]; 
}
int[,] a = arrRand();
int[,] b = arrRand();
int[,] c = Division(a, b);
PrintArray(a);

Console.WriteLine();
PrintArray(b);
Console.WriteLine();
PrintArray(c);

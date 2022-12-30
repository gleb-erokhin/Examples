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

void PrintArray(int[,] array) // печать результирующего массива
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

void Print2Array(int[,] a, int[,] b) // печать вводных массивов
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      Console.Write($"{a[i,j]} ");
    }
    Console.Write("| ");
    for (int j = 0; j < b.GetLength(1); j++)
    {
      Console.Write($"{b[i,j]} ");
    }
    Console.WriteLine();
  }
}

int[] Multiply(int[,] a, int[,] b)
{ 
  int[] res = new int[4];
  for (int i = 0; i < res.Length; i++)
    res[0] = ((a[0, 0] * b[0, 0])) + ((a[0, 1]) * (b[1, 0]));
    res[1] = ((a[0, 0] * b[0, 1])) + ((a[0, 1]) * (b[1, 1]));
    res[2] = ((a[1, 0] * b[0, 0])) + ((a[1, 1]) * (b[1, 0]));
    res[3] = ((a[1, 0] * b[0, 1])) + ((a[1, 1]) * (b[1, 1]));
  return res;
}

int[,] Convert(int[] a)  // Метод для перевода одинарного массива в двумерный массив
{
  int[,] c = new int[2, 2];
  int count = 0;
  for (int i = 0; i < c.GetLength(0); i++)
  {
    for (int j = 0; j < c.GetLength(1); j++)
    {
        c[i, j] = a[count];
        count ++;
    }
  }
  return c;
}

// Создаем два случайных двумерных массива и даем им переменные
int[,] a = arrRand();
int[,] b = arrRand();

// перемножаем данные двух массивов и получаем обычный массив из 4 значений
int[] c = Multiply(a, b);
 
// печатаем оба входных случайных массива
Console.WriteLine("Исходные массивы: ");
Print2Array(a, b);
Console.WriteLine();

// Печатаем результирующий массив
Console.WriteLine("Результирующий массив: ");
int[,] ans = Convert(c);
PrintArray(ans);

// для проверки что одинарный массив верный с результирующим
Console.WriteLine();
Console.WriteLine("одинарный массив, для проверки: ");

for (int i = 0; i < c.Length; i++)
{
  if(i == c.Length - 1) Console.Write($" {c[i]} ");
  else Console.Write($" {c[i]}, ");
}
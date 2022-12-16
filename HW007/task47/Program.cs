// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


decimal[,] arrRand()
{
    decimal[,] a = new decimal[3,4];
    // объявляем экземпляр класса Random
    Random rand = new Random();
    //  создаем дополнительные переменные для вычисления вещественного числа
    decimal min = -1;
    decimal max = 10 / 2;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            // получаем случайное вещественное число и сразу его округляем
            decimal randomdecimal = Math.Round((decimal)rand.NextDouble(), 2);
            // помещаем число в массив по индексам, применяя дополнительную обработку значения
            a[i,j] = (randomdecimal * (max - min)) + min;
        }
    }
    return a;
}

// печатаем массив
void PrintArray(decimal[,] array)
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

// вызываем функцию
decimal[,] x = arrRand();
PrintArray(x);
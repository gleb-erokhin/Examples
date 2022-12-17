// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] arrRand()
{
    int[,] a = new int[3,4];
    // в условии берем метод GET чтобы запросить размер массива, в скобках 0 первая часть двумерного массива i
    for (int i = 0; i < a.GetLength(0); i++)
    {
        //  тут тоже самое, только GET запрашивает длинну массива j
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(1, 10); 
        }
    }
    return a;
}

// метод печатает массив для визуального сравнения
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

void Change(int[,] array)
{
    int save = 0;
    int n = array.GetLength(0) - 1 ;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        save = array[0, i];
        array[0, i] = array[n, i];
        array[n, i] = save; 
    }
}

// создаем переменную для помещения в нее созданного массива
int[,] x = arrRand();
// печатаем массив
PrintArray(x);

Change(x);
Console.WriteLine();
PrintArray(x);


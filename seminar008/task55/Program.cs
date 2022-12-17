// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] arrRand()
{
    int[,] a = new int[4,5];
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            save = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = save;
        }
    }
}

// создаем переменную для помещения в нее созданного массива
int[,] x = arrRand();
// печатаем массив
PrintArray(x);
Console.WriteLine();

if (x.GetLength(0) != x.GetLength(1))
{
    Console.WriteLine("Невозможно заменить строки");
}
else
{
    Change(x);
    PrintArray(x);
}


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] arrRand()
{
    int[,] a = new int[5,5];
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

// найти координаты в данном массиве после передавать в функцию.
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

void SeachMin(int[,] array)
{
    int min = array[0,0];

}

void Change(int[,] array)
{
    int[,] answer = new int[4,4];
    int point = 0;

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

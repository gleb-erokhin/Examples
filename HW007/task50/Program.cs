// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Создаем массив 3 на 4, и наполняем его целыми случайными числамичислами 
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

// создаем метод который ищет в двумерном массиве, принимаем на вход 2 числа i, j и массив
void FindPosition(int num1, int num2, int[,] array)
{
    // если оба значения индекса меньше размера массива, то показываем число, если нет, то пишем что числа нет
    if (num1 < array.GetLength(0) && num2 < array.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine($"Число по индексу => {array[num1, num2]}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Такого числа в массиве нет");
    }
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

// создаем переменную для помещения в нее созданного массива
int[,] x = arrRand();
// печатаем массив
PrintArray(x);
// вводим данные для поиска, i, j, массив
FindPosition(1, 3, x);

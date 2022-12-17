// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


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

// Метод добавить который переводит двумерный массив в одномерный

void Count(int[] array)
{
    // { 2, 9, 9, 0, 2, 8, 0, 9 }
    int save = array[0]; // 2
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
       if (array[i] == save)
       {
            count++;
            if (i == array.Length - 1)
            {
                Console.WriteLine($"{save} - {count} шт");
            }
       }
       else
       {
            Console.WriteLine($"{save} - {count} шт");
            save = array[i];
            count = 1;
       }
    }


}

void CollectionSort(int[] array)
{
  for (int i=0; i<array.Length-1; i++)
  {
    int minPosition=i;
    for (int j=i+1; j<array.Length; j++)
    {
      if (array[j]< array[minPosition]) minPosition=j;
    }
        if (i!=minPosition)
    {
      int tmp=array[i];
      array[i]=array[minPosition];
      array[minPosition]=tmp;
    }
  }
}


int[] array = { 1, 4, 9, 0, 5, 8, 6, 6 };
// создаем переменную для помещения в нее созданного массива
// int[,] x = arrRand();
// печатаем массив
// PrintArray(x);

CollectionSort(array);
Count(array);
Console.WriteLine();
// PrintArray(x);
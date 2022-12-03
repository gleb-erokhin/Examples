// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] MethodRandom()
{
    int[] array = new int[8];
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(0, 2);
        i++; 
    }
    return array;

}

int[] x = MethodRandom();
Console.WriteLine(x);
// выводить через цикл

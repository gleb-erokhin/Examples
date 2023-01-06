// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Создаем из введенных значений n и m одномерный массив
int[] CreateArray(int m, int n)
{
    int[] array = new int[(n - m) + 1];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = m++;
    }
    return array;
}

// метод рекурсии для вычисленния суммы чисел от n до m
int Sum(int[] array, int i = 0)
{
    if(i >= array.Length) return 0;
    return array[i] + Sum(array, i + 1);
}

// печать массива для информации
void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
        Console.Write(a[i] + " ");
}

// Печать суммы после рекурсии
void printAns(int b)
{
    Console.WriteLine(b);
}

//  ---- вызываем методы ----

// Передаем входные данные m и n
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Создаем массив чисел от m до n
int[] x = CreateArray(m, n);
Console.WriteLine();

// Печатаем сформированный массив из чисел от m до n
Console.WriteLine($"Сформированный массив чисел от {m} до {n}: ");
PrintArray(x);
Console.WriteLine();

Console.WriteLine($"Сумма чисел от {m} до {n} равна: ");
int y = Sum(x);

if(y == 0) Console.WriteLine($"Внимание введено число n меньше m");
else printAns(y);

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] ArrayInput(int count) // Метод для наполения массива, передаем в параметр количество элементов
{
    int[] array = new int[count];
    Console.WriteLine($"Размер массива равен {count}");
    Console.WriteLine("Введите данные для массива в диапазоне от -1000 до 1000");

    // через цикл наполняем массив вводя значения по одному
    for(int i =0; i < array.Length; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

int GetCountNums(int[] array) // в цикле считаем количество элементов > 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}

void ArrayPrint(int[] value) // Печатаем введенный массив
{
    for (int i = 0; i < value.Length; i++)
    Console.Write($"{value[i]}, ");
}


Console.WriteLine("Введите размер массива");  // Вводим размер массива
int arraysize = Convert.ToInt32(Console.ReadLine());

int[] x = ArrayInput(arraysize);              // передаем размер массива в метод для наполнения массива
ArrayPrint(x);                                // Печатаем полученный массив         

Console.WriteLine();                          // Выводим ответ: сколько чисел > 0 в массиве
Console.WriteLine($"Чисел > 0 в массиве = {GetCountNums(x)}");























// int[] InputData(int value)
// {
//     int[] digit = new int[5];

//     for(int i = 0; i < digit.Length; i++)
//     {
//         digit[i] = value;
//         i++;
//     }
//     return digit;

// }

// Console.WriteLine("Введите 5 чисел от -1000 до 1000");
// int data = Convert.ToInt32.Console.ReadLine();
// int print = InputData(data);
// Console.WriteLine(print);

// for (int i = 0; i < x.Length; i++)
// Console.Write($"{x[i]}, ");

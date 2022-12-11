// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
int[] array2 = new int[10];
int count = array.Length - 1;

for (int i = 0; i < array.Length; i++)
{
    array2[count] = array[i];
    count--;
}

foreach (var n in array) Console.Write($" {n} |");
Console.WriteLine();
foreach (var r in array2) Console.Write($" {r} |");


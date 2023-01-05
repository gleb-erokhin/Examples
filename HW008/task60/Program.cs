// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] RandomTreeArray(int a, int b, int c)  // метод создания случайного трехмерного массива
{
    int[,,] rand = new int[a, b, c];
    for(int row = 0; row < rand.GetLength(0); row++)
    {
        for(int col = 0; col < rand.GetLength(1); col++)
        {
            for(int space = 0; space < rand.GetLength(2); space++)
            {
                rand[row, col, space] = new Random().Next(1, 10);
            }
        }
    }
    return rand;
}

void printArr(int[,,] a)  // метод печати трехмерного массива
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                Console.Write($"{a[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,,] inData = RandomTreeArray(n, m, k);
printArr(inData);

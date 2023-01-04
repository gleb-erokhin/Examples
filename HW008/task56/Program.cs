int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
int[] summ = new int[4];

for(int row = 0; row < array.GetLength(0); row++)
{
    int sum = 0;
    for(int col = 0; col < array.GetLength(1); col++)
    {
        sum = sum + array[row, col];
        // Console.WriteLine($"row = [{row}], col = [{col}], sum - {sum}, array - {array[row, col]}");
        // Вывод в консоль для тестирования
    }
    summ[row] = sum;
    // Console.WriteLine();
    // Console.WriteLine($"summ - {summ[row]}");
    //  вывод в консоль для тестирования
}

Console.WriteLine();
for(int i = 0; i < summ.Length; i++)
Console.Write($" {summ[i]} ");




        // for(int i = 0; i < array.GetLength(1) - 1; i++)
        // {
            
        // }
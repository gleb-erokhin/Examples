﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// объявляем массив
int[] array = {11, 21, 131, 41, 15, 16, 17, 18, 19};

// обращение к массиву, присвоить новое значение элементу массива
// array[0] = 12;
// Console.WriteLine(array[0]);


// с помощью массива ище число макс
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);
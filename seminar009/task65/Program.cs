// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


string nums = string.Empty;
string numRec(int num)
{
    if (num == 1) nums = "1 " + nums;
    else
    {
        nums = Convert.ToString(num) + " " + nums;
        numRec(num - 1);
    }
}

Console.WriteLine(numRec(5));
Console.WriteLine(nums);
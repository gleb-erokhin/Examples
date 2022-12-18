// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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
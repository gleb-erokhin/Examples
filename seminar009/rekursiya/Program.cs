int Factorial(int num)
{
    // главное написать условие выхода, может от меньшего больше, 
    if (num == 1) return 1;
    return num * Factorial(num - 1);

}

Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(5));

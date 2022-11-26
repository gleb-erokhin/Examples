// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// int numA = Convert.ToInt32(Console.ReadLine());
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA == numB * numB)
// {
//     Console.WriteLine($"Да, Является квадратом");
// }
// else
// {
//     Console.WriteLine($"Нет, не является квадратом");
// }

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine($"Понедельник");
}
else
{
    if (number == 2)
        {
          Console.WriteLine($"Вторник");
        }
    else 
    {
            if (number == 3)
        {
        Console.WriteLine($"Среда");
        }
        else {
            if (number == 4)
                {
                    Console.WriteLine($"Четверг");
                }
            else{
                if (number == 5)
                {
                    Console.WriteLine($"Пятница");
                }
                else{
                    if (number == 6)
                    {
                        Console.WriteLine($"Суббота");
                    }
                    else{
                        if (number == 7)
                        {
                            Console.WriteLine($"Воскресенье");
                        }
                        else{
                            Console.WriteLine($"Нет такого дня");
                        }

                    }
                }
            }    
    }   }
}



// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"








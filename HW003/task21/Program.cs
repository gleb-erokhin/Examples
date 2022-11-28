// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A =  new int[3];
int[] B =  new int[3];

Console.WriteLine("А1");
A[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("А2");
A[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A3");
A[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B1");
B[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B2");
B[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B3");
B[2] = Convert.ToInt32(Console.ReadLine());

// вещественное число получаем
double x = Math.Round
   (
        (
            Math.Sqrt
            (
                Math.Pow ((A[0] - B[0]), 2) + 
                Math.Pow ((A[1] - B[1]), 2) +
                Math.Pow ((A[2] - B[2]), 2)
            )
        )
, 2);
Console.WriteLine(x);
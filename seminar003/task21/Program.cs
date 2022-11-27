// 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int[] A =  new int[2];
int[] B =  new int[2];

Console.WriteLine("А1");
A[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("А2");
A[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B1");
B[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B2");
B[1] = Convert.ToInt32(Console.ReadLine());

// вещественное число получаем
double x = Math.Round((Math.Sqrt(Math.Pow ((A[0] - B[0]), 2) + Math.Pow ((A[1] - B[1]), 2))), 3);
Console.WriteLine(x);

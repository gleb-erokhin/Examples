// // краткая информация по строкам. Имеют очень много операций
string s1 = "Bob";
string s2 = "Mary";
// сложение строк конкатенация
string s3 = s1 + " - " + s2;
// Console.WriteLine(s3);

// // метод Concat
// string s4 = string.Concat(s1, " - ", s2);
// Console.WriteLine(s3);
// Console.WriteLine(s4);


// int num = 123;
// string sNum = Convert.ToString(num);
// Console.WriteLine(sNum);

// 19 домашка через строки, строка это набор символо, методы работают со строкой как с массивом

int s3Leng = s3.Length;
Console.WriteLine(s3Leng);

// обратимся по индексу
Console.WriteLine(s3[1]);

// строка работа с массивом метод join split

string[] names = {"Bob", "Ann", "Liz", "Mike"};
int[] ages = {10, 17, 15, 12};

// +++ join +++
// (с помощью чего объеденяем, множество какое обединяем)
string s10 = string.Join(" ", names);
Console.WriteLine(s10);

string s11 = string.Join("---", ages);
Console.WriteLine(s11);

// +++ split +++
string s = "1, 2, 3, 4, 5, 6, 7.";
// разбиваем через пустую строку
string[] nums = s.Split(' ');
// убрать запятые и точки, но мы получим подстроку между словом и запятой, split разъединяет - а не вырезает.
// string[] nums = s.Split(' ', '.', ',');
// string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);


// перебирает с каждой итерацией значение
foreach (var num in nums)
{
    Console.WriteLine($"Значение: {num}");
}
// перевести значения nums в числа
int[] n = nums.Select(Int32.Parse).ToArray();
foreach (var i in n)
{
    Console.Write($"{i} ");
}


//  короткий способ
// int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

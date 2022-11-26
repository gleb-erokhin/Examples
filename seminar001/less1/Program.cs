// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); // строки только в "" кавычках
Console.Write(123);  // цифры можно без скобок
string myName1 = "Bob"; // начало значения с маленькой буквы 
Console.Write(myName1);  
int age = 21;
Console.WriteLine(age);
int result; // подготавливаем зараее ячейку в памяти, чтобы потом использовать эту переменую

result = age / 10;  // целочисленное деление
result = age % 6;  // остаток от деления

age = age + 1; age += 1; age++;
Console.WriteLine(result);

//Ввод данных
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Это число {num}"); //подобие ф строк из питона $ вместо f

// Условия

if (num > age)
{
    Console.WriteLine($"{num} > {age}");
}
else
{
    Console.WriteLine($"{num} < {age}");
}



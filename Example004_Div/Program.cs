// // Деление целых чисел, опуская десяты
// int numberA = 12;
// int numberB = 5;

// // Заменив int на double мы получим уже как таковое вещественное число
// // double numberA = 12;
// // double numberB = 5;
// Console.WriteLine(numberA / numberB);

// +++++++++++++вторая половина+++++++++++++++++++

// получаем случайное число А
int numberA = new Random().Next(1, 10); // 1 2 3 4 5 . . . 9
// покажем загаданное число А
Console.WriteLine(numberA);
// получаем случайное число B
int numberB = new Random().Next(1, 10);
// покажем загаданное число B
Console.WriteLine(numberB);
Console.WriteLine(numberA + numberB);


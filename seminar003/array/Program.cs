// Массивы

// книга контактов, требуется знать имена друзей, все данные статичны, но будет очень сложно работать
// с такими данными при изменении удалении
    // string name1 = "Bob";
    // string name2 = "Vova";
    // string name3 = "Kolya";
    // string name4 = "Artem";

// В массиве можно легко оперировать с данными через переменную, так как Массив это сбор однотипных данных
// создадим массив. string - говорит что это строковый массив, данные в масиве доступны по индексу, начало с нуля

// создаем пустой массив
// string[] names = new string[5];
// Создаем массив с данными
string[] names = {"Bob", "Vova", "Kolya", "Artem"};

// вызовем значение из массива
// Console.WriteLine(names[1]);

// для работы с массивом можно использовать циклы, количество элементов в массиве измеряется с помощью метода Length
// for (int i = 0; i < names.Length; i++)
// Console.WriteLine(names[i]);

// Меняем данные в массиве
// for (int i = 0; i < names.Length; i++)
// Console.WriteLine(names[i]);
// names[0] = "Bob1";
// names[2] = "Liza";

// Замена элемента массива на последнем значении, так как мы можем не знать сколько элементов массива
// names[names.Length-1] = "Bob1";
// Console.WriteLine();
// for (int i = 0; i < names.Length; i++)
// Console.WriteLine(names[i]);


// Переьор всей коллекции
// foreach (string n in names)
// {
//     Console.WriteLine(n);
// }
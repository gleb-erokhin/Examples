// Создаем метод
// название метода, в скобках оптеделяем тип данных и создаем аргумент с произвольным именем
void FillArray(int[] collection) 
{
    // получаем длинну массива
    int length = collection.Length;
    int index = 0; //стартуем с нуля
    while(index < length)
    {
        // Аргумент с параметром индекса помещаем туда случайное целое число
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// Создаем массив с 10 элементами, но он будет заполнен нулями
int[] array = new int[10];
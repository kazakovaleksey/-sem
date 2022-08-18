// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых 
//  лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём 
// решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите размер массива: ");

int[] array = new int[123]; //создает массив

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-1000, 1000);
        index++;
    }

}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.Write(col[position] + " ");
    position++;
}
}


FillArray(array);
Console.WriteLine("Случайный массив:");
PrintArray(array);

int count = 0;

for (int i=0; i<123; i++)
{
    if (array[i]>10 && array[i]<100)
    count ++;
}
Console.WriteLine(string.Empty);
Console.WriteLine($"Количество чисел лежащих в отрезке [10, 99]: {count}");

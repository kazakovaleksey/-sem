// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив

int count = 0; // счетчик четных чисел в массиве

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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

for (int i=0; i <= array.Length-1; i++)

{
    if (array[i] %2 == 0)
    count++;
}
Console.WriteLine(string.Empty);
Console.WriteLine($"Количество четных числел: {count}");
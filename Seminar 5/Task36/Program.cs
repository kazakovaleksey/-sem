// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N]; //создает массив

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

int sum = 0;

for (int i = 0; i <= array.Length-1; i+=2)
{
    sum = sum + array[i];
}

Console.WriteLine(string.Empty);
Console.WriteLine(sum);
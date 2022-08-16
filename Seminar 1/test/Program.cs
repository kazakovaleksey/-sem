// создадим рандомный массив чисел N 




Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 999);
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

int maxval = array.Max();
Console.WriteLine("");
Console.WriteLine("Максимальный элемент масиива: " + maxval);

int indexMax = Array.FindIndex(array, item => item == maxval);
Console.WriteLine("Индекс максимального элемента массива: " + indexMax);

int minval = array.Min();
Console.WriteLine("Минимальный элемент масиива: " + minval);

int indexMin = Array.FindIndex(array, item => item == minval);
Console.WriteLine("Индекс минимального элемента массива: " + indexMin);
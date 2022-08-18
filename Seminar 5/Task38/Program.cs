// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив

int x = 0;

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



int minval = array.Min();
Console.WriteLine("Минимальный элемент масиива: " + minval);

Console.WriteLine( x =maxval-minval);

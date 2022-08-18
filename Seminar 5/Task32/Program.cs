// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
//  и наоборот.


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

void revers(int[] revers)
{

    for (int i =0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        array[i] = array[i] * -1;
        }
        else
        {
        array[i] = Math.Abs(array[i]);    
        }
    }
}


FillArray(array);
Console.WriteLine("Случайный массив:");
PrintArray(array);
revers(array);
Console.WriteLine("инвертированы положительные числа:");
PrintArray(array);


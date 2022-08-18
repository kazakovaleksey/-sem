// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
Console.WriteLine(string.Empty);
Console.WriteLine("Введите число для поиска: ");
int x  = Convert.ToInt32(Console.ReadLine());
int count = 0;//счетчик искомого числа

for (int i=0; i<array.Length; i++)
{
    if (array[i] == x)
    {
        count++;
    }
}

if (count>0)
{
   Console.WriteLine("да"); 
}
else
{
    Console.WriteLine("нет"); 
}
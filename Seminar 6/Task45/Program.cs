// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.
// что бы не вводить произвольный массив, сделаем заполнение рандомными числами, от пользователя спросим только размер массива

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив
int[] array2 = new int[N]; //создает массив2

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

void CopyArray(int[] a, int[] b)
{
for (int i=0; i < a.Length; i++)
{
b[i]=a[i];
}

}


FillArray(array);
Console.WriteLine("Случайный массив:");
PrintArray(array);
Console.WriteLine(string.Empty);
Console.WriteLine("болванка для копируемого массива (пока пустой):");
PrintArray(array2);
Console.WriteLine(string.Empty);
CopyArray(array, array2);
Console.WriteLine("Копия массива");
PrintArray(array2);
Console.WriteLine(string.Empty);

array2[0] = 999; // проверим что изменяется только копия

Console.WriteLine("оригинал (первое число сохранено):");
PrintArray(array);
Console.WriteLine(string.Empty);
Console.WriteLine("копия (первое число изменено):");
PrintArray(array2);
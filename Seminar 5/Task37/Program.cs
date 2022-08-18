// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//   Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
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

int[] array2 = new int[N/2+N%2];

for (int i =0; i <(array2.Length); i++)
    {
     array2[i]=array[i] * array[(N-1-i)];
    }    
    
 if (array.Length%2 > 0)
{
    array2[(N/2+(N%2)) -1] = array[N/2];
}

Console.WriteLine(string.Empty);
PrintArray(array2);
//Console.WriteLine(array2[N/2+(N%2)]);
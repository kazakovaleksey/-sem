// Доп. задача
// Написать программу для разворота массива

Console.WriteLine("Введите размер массива: ");
int N  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N]; //создает массив
int[] array2 = new int[N];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 99);
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
    Console.WriteLine("");
}

void RotateArray(int[] orig, int[] rot)
{
    for (int index = 0; index < orig.Length; index++)
    {    
        rot[index] = orig[orig.Length-1-index];
    }
}



FillArray(array);
Console.WriteLine("Случайный массив:");
PrintArray(array);
Console.WriteLine("Развернутый массив:");
RotateArray(array, array2);

PrintArray(array2);

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

Console.WriteLine("Введите размерность массива через пробел :");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);


int[,] matrix = new int[M, N];


void PrintArray2D(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            Console.Write(array2d[i, j] + " ");
        Console.WriteLine();
    }

}

void FillArray2D(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }

}

void FindIndex(int[,] array, int x)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x) { count++; }
        }
    }
    if (count > 0)
       { Console.WriteLine($"{x} встречается {count} раз");}

}

FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);

for (int i = 0; i <= 9; i++)
{
    FindIndex(matrix, i);
}


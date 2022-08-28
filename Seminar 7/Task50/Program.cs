// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите размерность матрицы через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);

int[,] matrix = new int [M,N];

void PrintArray2D(int[,] array2d)
{
for (int i = 0; i < array2d.GetLength(0); i++ )
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        Console.Write($"{array2d[i,j]}"+" ");
        Console.WriteLine();
    }
    
}


void FillArray2D(int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j =0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,100);
    }
}

}

void IndexSearch(int[,] mat, int i, int j)
{
    if (i > mat.GetLength(0) || j > mat.GetLength(1))
    {
        Console.WriteLine("Нет такого элемента в исходном массиве");
    }
    else
    {
       Console.WriteLine($"Искомый элемент с индексом ({i},{j}): {mat[i-1,j-1]}");
    }
}

FillArray2D(matrix);

Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);

Console.WriteLine("Введите позицию искомого элемента через пробел:");
string q = Console.ReadLine();
string[] s_array = q.Split();
int i = int.Parse(s_array[0]);
int j = int.Parse(s_array[1]);

IndexSearch(matrix, i, j);


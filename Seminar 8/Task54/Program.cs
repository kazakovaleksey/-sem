// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите размерность массива через пробел:");
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

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                 for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
                {                 
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                    }
                }
            }
        
    }
}

FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);
SortArray(matrix);
Console.WriteLine(string.Empty);
PrintArray2D(matrix);
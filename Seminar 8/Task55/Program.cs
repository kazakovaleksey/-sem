// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите размерность массива через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);



int[,] matrix = new int[M, N];
int[,] transponmatrix = new int[N, M];

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

void ReverseArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            
            array2[i, j] = array[j, i];
            
        }
    }
}


FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);

ReverseArray(matrix, transponmatrix);
Console.WriteLine("поменяны местами 1 и последние строки:");
PrintArray2D(transponmatrix);

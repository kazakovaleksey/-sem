// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность матриц через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);


int[,] matrix1 = new int[M, N];
int[,] matrix2 = new int[M, N];


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



FillArray2D(matrix1);
Console.WriteLine($"Случайная матрица 1 {M}x{N}:");
PrintArray2D(matrix1);
Console.WriteLine(string.Empty);
FillArray2D(matrix2);
Console.WriteLine($"Случайная матрица 2 {M}x{N}:");
PrintArray2D(matrix2);

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int[,] resultMatrix = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
            resultMatrix[i, j] = matr1[i, j] * matr2[i, j];
    }

    return resultMatrix;
}

int[,] multiMatrix = MultiplicationMatrix(matrix1, matrix2);


Console.WriteLine(string.Empty);
Console.WriteLine("Итог произведения матриц:");
PrintArray2D(multiMatrix);
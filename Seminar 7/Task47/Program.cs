// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность матрицы через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);

double[,] matrix = new double [M,N];

void PrintArray2D(double[,] array2d)
{
for (int i = 0; i < array2d.GetLength(0); i++ )
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        Console.Write(Math.Round(array2d[i,j], 2) +" ");
        Console.WriteLine();
    }
    
}


void FillArray2D(double[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j =0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().NextDouble()*10 ;
    }
}

}

FillArray2D(matrix);
PrintArray2D(matrix);



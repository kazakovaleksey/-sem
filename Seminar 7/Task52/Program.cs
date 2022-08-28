// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность матрицы через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);

int[,] matrix = new int [M,N];
double mid = new double [N];

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
        matr[i,j] = new Random().Next(1,10);
    }
}

}


void MidColumns(int[,] sourcearray, double[] midarray)
{
    double mid =0;
    for (int j=0; j < sourcearray.GetLength(1); j++)
        for (int i =0; i < sourcearray.GetLength(0); i++)
        {
        mid = mid + sourcearray[i,j];
        }
        midarray[j] = mid/sourcearray.GetLength(0);
        mid = 0;
}

FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Join(" ", midarray));


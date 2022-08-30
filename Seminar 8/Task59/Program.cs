// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.WriteLine("Введите размерность матрицы через пробел:");
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

int[,] ReverseArray(int[,] array)
{
int[,] NewMatrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int minValue = array[0, 0];
    int rowMin = 0;
    int columnMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                rowMin = i;
                columnMin = j;
            }
        }
    }

    int rowOffset = 0;
    int columnOffset = 0;

    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        if ( i == rowMin) {rowOffset ++;}
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            if ( j == columnMin) {columnOffset ++;}
            NewMatrix[i, j] = array[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    return NewMatrix;
}

FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);

int[,] newMatrix = ReverseArray(matrix);
PrintArray2D(newMatrix);

// Console.WriteLine("поменяны местами 1 и последние строки:");
// PrintArray2D(transponmatrix);
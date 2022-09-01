// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindMinRowSum(int[,] mat)
{
    int sum = 0;
    int[] arraySum = new int[mat.GetLength(0)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
       sum =0;
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            sum = sum + mat[i,j];
        }
        arraySum[i] = sum;
        
    }
    return arraySum;
}

FillArray2D(matrix);
Console.WriteLine($"Массив случайных чисел {M}x{N}:");
PrintArray2D(matrix);


int[] arraySum = FindMinRowSum(matrix);

//Console.WriteLine(string.Join(" ", arraySum));

int minval = arraySum.Min();
Console.WriteLine("Минимальная сумма: " + minval);

int indexMin = Array.FindIndex(arraySum, item => item == minval) +1;
Console.WriteLine("Находится в строке: " + indexMin);
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
        matr[i,j] = new Random().Next(1,10);
    }
}

}

FillArray2D(matrix);
PrintArray2D(matrix);

int sum =0;

    for (int i = 0; i < matrix.GetLength(0); i+=1)
    {
        int j = i;
        
            sum = sum + matrix[i,j];

        j +=2;
    }


    Console.WriteLine(sum);


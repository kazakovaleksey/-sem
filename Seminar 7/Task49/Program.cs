// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void ChangeIndex(int[,] mat)
{
    for (int i =1; i < mat.GetLength(0); i+=1)
    {
        int j = i;
        
            mat[i,j] = (int)Math.Pow(mat[i,j],2);

        j +=2;
    }
}

FillArray2D(matrix);
PrintArray2D(matrix);

ChangeIndex(matrix);

Console.WriteLine("Измененный массив:");
PrintArray2D(matrix);
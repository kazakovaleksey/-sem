//создадим рандомный двухмерный массив [3,4]

// Console.WriteLine("Введите размерность матрицы строки:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность матрицы столбцы:");
// int N = Convert.ToInt32(Console.ReadLine());

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
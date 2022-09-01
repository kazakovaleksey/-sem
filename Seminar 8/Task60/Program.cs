// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите размерность матриц через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);
int L = int.Parse(s_arr[1]);


if (M*N*L > 90)
{
    Console.WriteLine("Не может быть создано более 90 уникальных двухзначных чисел");
   Environment.Exit(0);
 
}


int[,,] matrix1 = new int[M, N, L];

void PrintArray3D(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]}" + $"({i},{j},{k})" + " ");

            }
            Console.WriteLine();
        }
    }

}

bool IsUniqueValue(int[,,] matr, int x) //метод проверки уникально ли сгенерированное случайное число
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {

                if (matr[i, j, k] == x)
                {
                    return false;
                }

            }
        }
    }
    return true;
}

int CheckIndex(int[,,] matr) // метод поледней проверки, сколько в созданном массиве уникальных чисел
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {

                if (IsUniqueValue(matr, matr[i, j, k]) == false)
                {
                    count++;
                }

            }
        }
    }
    return count;
}

void FillArray3D(int[,,] matr)
{
    int s = new Random().Next(10, 99);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                while (IsUniqueValue(matr, s) == false)
                {
                    s = new Random().Next(10, 99);
                }
                matr[i, j, k] = s;
            }
        }
    }

}

FillArray3D(matrix1);

PrintArray3D(matrix1);

Console.Write($"Количество уникальных элементов: {CheckIndex(matrix1)} из: {M*N*L}");
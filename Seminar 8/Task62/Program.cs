// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

            const int n = 4;
            const int m = 4;
            int[,] mas = new int[n, m];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[row, col] = i + 1;
                if (--gran == 0)
                {
                    gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }               
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
                
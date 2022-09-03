// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите размерность массива через пробел :");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int N = int.Parse(s_arr[0]);
int M = int.Parse(s_arr[1]);

if (M >= 0 && N >= 0)
{
    int sum = Sum(N, M);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Числа не могут быть отрицательными!!!");
}

int Sum(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Sum(m - 1, 1);
    }
    else
    {
        return Sum(m - 1, Sum(m, n - 1));
    }
}
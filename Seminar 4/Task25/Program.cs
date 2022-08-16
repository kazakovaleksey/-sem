// Задача 25: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int M = Convert.ToInt32(Console.ReadLine());
int p=1;
//Console.WriteLine(Math.Pow(N , M));

for (int i = 0; i<M; i++)
{
    p=p*N;
}
Console.WriteLine(p);
//Console.WriteLine(string.Join(", ", arr));

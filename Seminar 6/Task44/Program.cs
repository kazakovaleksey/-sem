// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество числе для отображения: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Fibo = new int[N];
Fibo[0] = 0;
Fibo[1] = 1;

for (int i = 2; i < N; i++)
{
    Fibo[i] = Fibo[i - 2] + Fibo[i - 1];
}

for (int i = 0; i < N; i++)
{
    Console.Write(Fibo[i] + " ");
}
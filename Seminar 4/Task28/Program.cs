// Задача 28: Напишите программу, которая принимает на
//  вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число для вычисления факториала: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 0)

{
    Console.WriteLine("!0 = 1");
}
else
{
    int F = 1;

    for (int i = 1; i <= N; i++)
    {
        F = F * i;
    }

    Console.WriteLine($"!{N}={F}");
}
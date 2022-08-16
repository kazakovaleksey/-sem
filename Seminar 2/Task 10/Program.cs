// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число [100..999]: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ((99 < number1) && (number1<1000))
{
    int digit12 = (number1/10)%10;

Console.WriteLine(digit12); 
}



else
{
    Console.WriteLine("число не трехзначное!"); 
}
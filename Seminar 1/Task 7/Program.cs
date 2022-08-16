// Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 & number < 1000)
{
Console.Write(number % 10);    
}
else
{
  Console.Write("Число не трехзначное");      
}
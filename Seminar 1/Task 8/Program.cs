// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int counter = 0;

Console.WriteLine("Четные числа до числа N:");
while (counter <= number1)

{
 Console.WriteLine( counter );
    counter+=2;

}
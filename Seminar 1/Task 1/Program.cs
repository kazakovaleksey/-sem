// проверка квадрата первого числа

Console.WriteLine("Введите число 1 : ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
double number2 = Convert.ToDouble(Console.ReadLine());

if
(number1 == number2 * number2 )
    Console.WriteLine("Первое число квадрат второго числа");
else
{
    Console.WriteLine("Первое число НЕ квадрат второго числа");
}

// Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Делим десятичное число на 2 и записываем остаток от деления.
// Результат деления вновь делим на 2 и опять записываем остаток.
// Повторяем операцию до тех пор пока результат деления не будет равен нулю.
// Запишем полученные остатки в обратном порядке и получим искомое число.

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.Write(col[position] + " ");
    position++;
}
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = N;
int length = Convert.ToInt32(Math.Floor(Math.Log(N, 2)) + 1); // определим размер массива для записи числа в двоичном коде

int[] digit = new int[Convert.ToInt32(length)];

for (int i = 0; i < length; i++)
{
    digit[length - 1 - i] = N%2;
    N = N/2;
}

Console.WriteLine($"Число {x} в двоичном коде:");
PrintArray(digit);
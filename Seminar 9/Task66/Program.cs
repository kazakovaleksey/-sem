// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите размерность массива через пробел :");
string s = Console.ReadLine();
string[] s_arr = s.Split();
int M = int.Parse(s_arr[0]);
int N = int.Parse(s_arr[1]);

int sum = 0;
int[] arr = new int[N - M + 1];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = (M + i);
    sum = sum+ arr[i];
}

Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(sum);


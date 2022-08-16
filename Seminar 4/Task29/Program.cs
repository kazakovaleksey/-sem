// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран. 
// Вводим массив через консоль


//Вариант ввода через Enter

Console.WriteLine("Введите 1 элемент массива: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 элемент массива: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 элемент массива: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 4 элемент массива: ");
int a4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 5 элемент массива: ");
int a5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 6 элемент массива: ");
int a6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 7 элемент массива: ");
int a7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 8 элемент массива: ");
int a8 = Convert.ToInt32(Console.ReadLine());

int[] arr = {a1,a2,a3,a4,a5,a6,a7,a8};

for (int i=0; i<arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}
Console.WriteLine(String.Empty);
Console.WriteLine("[{0}]", string.Join(", ", arr));
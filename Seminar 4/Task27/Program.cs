// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
// int N  = Convert.ToInt32(Console.ReadLine());
string S = Console.ReadLine();
// Console.WriteLine(S.Length);
// Console.WriteLine(Convert.ToInt32(S[1]- '0'));
//int[] array = new int[N]; //создает массив

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = Convert.ToInt32(S[index] - '0');
//         index++;
//     }

// }

// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
//     Console.Write(col[position] + " ");
//     position++;
// }
// }
// FillArray(array);
// PrintArray(array);
int sum =0;
for (int i=0; i<S.Length; i++)
{
     sum = sum + Convert.ToInt32(S[i] - '0');
     
}

Console.WriteLine(sum);






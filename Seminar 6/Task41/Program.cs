// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите произвольное количество чисел через пробел:");
string s = Console.ReadLine();
string[] s_arr = s.Split();

int count = 0;
for (int i = 0; i < s_arr.Length; i++)
{
    if (Convert.ToInt32(s_arr[i]) > 0)
    {
        count++;
    }
}

Console.WriteLine($"пользователь ввел {count} чисел(а) больше 0");



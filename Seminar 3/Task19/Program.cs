// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string N = Console.ReadLine();

if (N.Length<6 && N.Length>1)
{
    
char[] chars = N.ToCharArray(); // описываем массив символов, преобразуя строку в массив
        if (chars[0]==chars[4] && chars[1]==chars[3])
        {
            Console.WriteLine("Число - полиндром");
        }
        else 
        {
            Console.WriteLine("Число - НЕ полиндром");
        }
}
else 
{
    Console.WriteLine("Введено не пятизначное число");
}

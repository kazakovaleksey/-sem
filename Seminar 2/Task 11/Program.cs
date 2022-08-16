// Задача 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int random = new Random().Next(100,1000);
Console.WriteLine(random);

int digit1 = random / 100;
int digit3 = random % 10;
Console.WriteLine($"{digit1}{digit3}");



// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//Расстояние между точками — это число, равное корню из суммы квадратов 
//разностей координат точек или длине разности радиус-векторов точек



Console.WriteLine("координаты первой точки (поочередно, через Enter): ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"точка 1: ({x1},{y1})): ");


Console.WriteLine("координаты второй точки (поочередно, через Enter): ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"точка 2: ({x2},{y2})): ");

double S = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
Console.WriteLine($"Расстояние между точками = {S}: ");

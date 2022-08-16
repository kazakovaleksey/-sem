// // создание метода 

// Console.WriteLine("Введите число для вычисления факториала: ");
// int N = Convert.ToInt32(Console.ReadLine());





// void fac(int a)
// {

//     if (N == 0)

//     {
//         Console.WriteLine("!0 = 1");
//     }
//     else
//     {
//         int F = 1;

//         for (int i = 1; i <= N; i++)
//         {
//             F = F * i;
//         }

//         Console.WriteLine($"!{N}={F}");
//     }
// }

// fac(N);

double x = Math.E;
Console.WriteLine("E={0:##.##}", x); // не более шести знаков
Console.WriteLine("E={0:0.00}", x); // ровно шесть знаков
Console.WriteLine("E={0:F2}", x); // число с плавающей точкой и 6 знаков после запятой

Console.WriteLine("N");

double N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("M");

double M = Convert.ToInt32(Console.ReadLine());
double d = N/M;
Console.WriteLine("d={0:##.##}", d);

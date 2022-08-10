// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double a = 0;
double c = 0;
double x = 0;
double y = 0;
a = k1 - k2;
c = b1 - b2;
x = (c * -1) / a;
y = (k2 * x) + b2;
Console.WriteLine( $"({x}, {y})");
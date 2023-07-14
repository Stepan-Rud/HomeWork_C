// Задача 43: Напишите программу, которая найдёт точку
//  пересечения двух прямых, заданных уравнениями
//   y = k1 * x + b1, y = k2 * x + b2; значения
//    b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 || b1 == b2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

var x = X(k1, b1, k2, b2);
var y = Y(k1, b1, x);

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");

double X(double K1, double B1, double K2, double B2)
{
    double numbX = -(B1 - B2) / (K1 - K2);
    return numbX;
};

double Y(double K1, double B1, double X1)
{
    double numbY = y = K1 * X1 + B1;
    return numbY;
}
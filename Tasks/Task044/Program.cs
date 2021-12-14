// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double b1 = 5;
double b2 = 3; 
double k1 = 6;
double k2 = 3;

if (k1 == k2)
{
    Console.WriteLine("ERROR");
}
double x = (double)(b2-b1)/(k1-k2);
Console.WriteLine($"{x} - x");
double y1 = k1 * x + b1;
Console.WriteLine($"{y1} - y1");
double y2 = k2 * x + b2;
Console.WriteLine($"{y2} - y2");

if(y1==y2)
{
    Console.WriteLine($"{y1} {y2} точка пересечения");
}

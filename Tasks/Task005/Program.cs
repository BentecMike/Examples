// Написать программу вычисления значения функции y = f(a) y = a^3 * 2 + 15

double a = new Random().Next (1, 10);
Console.WriteLine(a);
double y = Math.Pow (a, 3) * 2 + 15;

double f(double a, double y)
{
    y = a * a * a * 2 + 15;
    return y;
}

Console.WriteLine(y);


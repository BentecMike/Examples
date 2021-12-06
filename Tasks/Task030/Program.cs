// Показать кубы чисел, заканчивающихся на четную цифру

double a;
int N = 10000;

static double Kvadrat(double a)
{
    return a * a * a;
}

for (a = 1; a <= N; a++)
{
    Kvadrat(a);
    double A = a % 10 % 2;
    if (A == 0)
        Console.WriteLine($"{a}        {a * a * a}    {A}");
}

// Написать программу масштабирования фигуры

double[] mass = { -1, 1, -2, -6, 11, 6, 11, 1, 12, 0}; //{x1, y1, x2, y2, .... y4 }
int length = mass.Length;
Console.WriteLine("Введите коэффициент кх: ");
double kx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент ку: ");
double ky = double.Parse(Console.ReadLine());


void Mashtab(double[] mass)
{
    double X = 0;
    double Y = 0;
    int i = 0;
    for (int count = 0; count < mass.Length; count++)
    {
        int a = count % 2;
        if (a == 0)
        {
            X = mass[i] * kx;
            mass[i] = X;
        }
        if (a != 0)
        {
            Y = mass[i] * ky;
            mass[i] = Y;
        }
        i++;
    }
}


void PrintArray0(double[] mass)
{
    int count = mass.Length;
    int pos = 0;
    int con = 1;
    while (pos < count)
    {
        Console.WriteLine($"{mass[pos]}; {mass[pos + 1]} координаты точки {con}");
        pos = pos + 2;
        con++;
    }
}

void PrintArray(double[] mass)
{
    int count = mass.Length;
    int pos = 0;
    int con = 1;
    while (pos < count)
    {
        Console.WriteLine($"{mass[pos]}; {mass[pos + 1]} новые координаты точки {con}");
        pos = pos + 2;
        con++;
    }
}
PrintArray0(mass);
Console.WriteLine();
Mashtab(mass);
PrintArray(mass);

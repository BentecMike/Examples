// По двум заданным числам проверять является ли одно квадратом другого

int a = new Random().Next (4, 26);
Console.WriteLine(a);
int b = new Random().Next (1, 6);
Console.WriteLine(b);

if (a == Math.Pow (b, 2))
Console.WriteLine($"{a}{" является квадратом"} {b}");
else
Console.WriteLine($"{a}{" не является квадратом"} {b}");
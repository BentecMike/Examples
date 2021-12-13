// Выяснить являются ли три числа сторонами треугольника

int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
int c = new Random().Next(1, 100);
Console.WriteLine($"{a}, {b}, {c}");

if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine($"Числа {a}, {b}, {c} являются сторонами треугольника");
    }
else 
    {
        Console.WriteLine($"Числа {a}, {b}, {c} НЕявляются сторонами треугольника");
    }
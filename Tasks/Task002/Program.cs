// По двум заданным числам проверять является ли первое квадратом второго
int a = 16; int b = new Random().Next(1, 10);
Console.WriteLine(b);

if (a == b * b)
    Console.WriteLine("Первое число является квадратом второго");
else
    Console.WriteLine("Первое число не является квадратом второго");
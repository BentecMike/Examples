// Выяснить является ли число чётным

int a = new Random().Next(1, 35);
Console.WriteLine(a);

int b = a % 2;
if (b == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");

// Возведите число А в натуральную степень B используя цикл

Console.WriteLine($"Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите степень: ");
int B = int.Parse(Console.ReadLine());
int prom = 1;
for (int i = 0; i < B; i++)
{
    prom *= A;
    if (i == B) ;
    Console.WriteLine(prom);

}
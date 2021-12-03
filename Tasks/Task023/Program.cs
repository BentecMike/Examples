// Показать таблицу квадратов чисел от 1 до N 
int a;
int N = 20;

static int Kvadrat (int a)
    {
        return a*a; 
    }

for (a = 1; a <= N; a++ )    
    {
        Kvadrat(a);
        Console.WriteLine($"{a}        {a*a}");
        
    }
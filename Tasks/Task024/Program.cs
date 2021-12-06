// Найти кубы чисел от 1 до N (N=20)

int a;
int N = 100;

static int Kvadrat (int a)
    {
        return a*a*a; 
    }

for (a = 1; a <= N; a++ )    
    {
        Kvadrat(a);
        Console.WriteLine($"{a}        {a*a*a}");
        
    }
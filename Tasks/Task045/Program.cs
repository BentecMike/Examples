// Показать числа Фибоначчи 1 1 2 3 5 8 13 21 34 55 89


int prom = 1;
int count = 44; // после 44 надо использовать тип double
int result = 1;
int fib = 0;
Console.Write($"{prom}  {result}  ");

for (int i = 0; i < count; i++)
{
    fib = prom + result;
    prom = result;
    result = fib;
    Console.Write($"{fib}  ");
}

// Написать программу вычисления произведения чисел от 1 до N

double N = int.Parse(Console.ReadLine());
double result = 1;
for (int i = 1; i <= N; i++)
{
	result *= i;
}
Console.WriteLine(result);

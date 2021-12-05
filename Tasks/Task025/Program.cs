// Найти сумму чисел от 1 до А

int N = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 1; i <= N; i++)
{
	result += i;
}
Console.WriteLine(result);

// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("введите число: ");
string a = Console.ReadLine();
int length = a.Length;
int b = 0;
int count = 0;

for (int index = 0; index < length; index++)
{
    b = Convert.ToInt32(a[index]-'0');
    Console.WriteLine(b);
    if (b > 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} чисел больше нуля ввеедено с клавиатуры");

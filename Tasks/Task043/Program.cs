// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());

string Preobraz(int numb)
{
    string result = String.Empty;
    int value = 3;
    while (numb > 0)
    {
        value = numb % 2;
        result = value.ToString() + result;
        numb = numb / 2;
    }
    return result;
}

string poz = Preobraz(a);
Console.WriteLine(poz);

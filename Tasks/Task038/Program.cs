// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(20);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

void summArray(int[] collection)
{
    int length = collection.Length;
    int sum = 0;
    int i = 0;
    int temp = i % 2;
    bool result = temp == 0;
    for (i = 1; i < length; i++)
    {
        if (result)
        {
            sum = sum + collection[i];
            i++;
        }
        else
        {
            i++;
        }
    }
    Console.WriteLine($"сумма нечетных индексов равна {sum} ");
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
summArray(array);


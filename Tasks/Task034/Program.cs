// Написать программу замену элементов массива на противоположные

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
        index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void PrintArrayNew(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]*-1);
        position++;
    }
}

int[] array = new int[12];

FillArray(array);
PrintArray(array);
Console.WriteLine("now new array");
PrintArrayNew(array);
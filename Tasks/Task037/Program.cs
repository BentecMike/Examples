// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(123);
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

void someMethod(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    int j = 0;
    int m = 0;
    for (i = 0; i < length; i++)
    {
        if (collection[i] >= 10 && collection[i] <= 99)
        {
            Console.Write($"{collection[i]} ");
            j++;
        }
        else
        {
            //Console.Write($"{collection[i]} ");
            m++;
        }
    }
    Console.WriteLine($"   {j} раз");
    //Console.WriteLine($"     {m} раз");
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
someMethod(array);


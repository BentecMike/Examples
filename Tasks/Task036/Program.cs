// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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

void sortNum0(int [] col)
{
    int length = col.Length;
    int j = 0;
    for (int i = 0; i < col.Length;)
    {
    int prom = col[i] % 2;
        if (prom == 0)
        { 
            Console.Write($"{col[i]} ");
            j++;
        }
        i++;
    }
     Console.Write($"{j} {"четных чисел"}");
}

void sortNum1(int [] col)
{
    int length = col.Length;
    int j = 0;
    for (int i = 0; i < col.Length;)
    {
    int prom = col[i] % 2;
        if (prom > 0)
         {
             Console.Write($"{col[i]} ");
             j++;
         }
     i++;
    }
     Console.Write($"{j} {"нечетных чисел"}");
    
}

int[] array = new int[20];
FillArray(array);
PrintArray(array);
Console.WriteLine();
sortNum0(array);
Console.WriteLine();
sortNum1(array);




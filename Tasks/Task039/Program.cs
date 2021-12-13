// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void MultiIndexArray(int[] collection)
{   
    int length = collection.Length;
    int multi = 0;
    int temp = length % 2;
    bool result = temp == 0;
    if (result)
    {
        for (int i = 0; i < length / 2; i++)
        {
            multi = collection[i] * collection[length - 1 - i];
            Console.WriteLine(multi);
        }
    }
    else
    {
        for (int i = 0; i < length / 2; i++)
        {  
            multi = collection[i] * collection[length - 1 - i];
            Console.WriteLine(multi);
        }        
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MultiIndexArray(array);

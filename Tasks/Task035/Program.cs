// Определить, присутствует ли в заданном массиве, некоторое число


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

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int n = array.Length;
Console.WriteLine("Введите искомое число: ");
int find = int.Parse(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"{array[index]} {"искомое число есть в массиве"}");
        break;
    }
    index++;
}
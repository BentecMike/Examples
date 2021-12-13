// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(50, 100) / 10.0;
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}  ");
        position++;
    }
}

double [] FindMinMax (double [] collection)
{
    double min = collection[0];
    double max = collection[0];
    double [] minMax = new double [2]; 
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min)
        {
            min = collection[i];
            minMax[0] = min;
        }    
        if (collection[i] > max)
        {
            max = collection[i];
            minMax[1] = max;
        }
    }
return minMax;

}

double [] array = new double [10];

FillArray(array);
PrintArray(array);
FindMinMax(array);
Console.WriteLine();

double [] result = FindMinMax(array);
PrintArray(result);

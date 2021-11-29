//Показать четные числа от 1 до N

int[] array = Enumerable.Range(1, 100000000).ToArray();

int count = array.Length;
for (int i = 0; i < array.Length - 1;)
{
    array[i] = i+1;
    int prom = i % 2;
    if (prom == 1)
        Console.Write($"{array[i]} ");
        i++;
    
}
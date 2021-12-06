// Задать массив из 8 элементов и вывести их на экран 

int[] array = {2, 4, 8, 6, 7, 22, 96, 88, 21, 45, 66, 91, 20, 64, 87, 86, 10, 1, 3}; //Enumerable.Range(1, 9).ToArray();
int i = 0;
int count = array.Length;
while ( i < count)
{
    Console.Write($"{array[i]} ");
    i++;
}

// Показать числа от -N до N
int[] array = new int[5000000];

//int[] array = {-10, -9, -8, -7, -6, -5, -4, -3, -2, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = array.Length;
for (int i = 0; i < array.Length - 1; i++)
{
    array[i] = new Random().Next(-2014856, 25541617);
    Console.Write($"{array[i]} ");
}
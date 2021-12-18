//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


int[,] array = new int[10, 15];  
int a = 0;
int b = 0;

void FillArray (int [,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {   
        a++;
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    } 
    Console.WriteLine($"{a} {b}");
}

void PrintArray (int [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0,4}", collection[i, j]);
        }
    Console.WriteLine();
    }
}

void middleElem(int[,] array)
{  
        double midle = 0;
        double sum = 0;
        int i = 0;
        int j = 0;
        for (i = 0; i < a; i++)
        {   
            sum = 0; 
            for (j = 0; j < a; j++)
            { 
                sum = sum + array[j,i];
                Console.WriteLine($"sum = {sum}");
                if (j == a-1)
                {
                    midle = sum / a;
                     Console.WriteLine($"{b} столбец среднее арифметическое = {midle} ");
                     Console.WriteLine($"j = {i}");
                    b++;
                }
            }
        }
}

FillArray(array);
PrintArray(array);
middleElem(array);


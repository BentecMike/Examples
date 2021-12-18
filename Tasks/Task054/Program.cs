// В матрице чисел найти сумму элементов главной диагонали

int[,] array = new int[8, 8];  
int i = 0;
int j = 0;  

void FillArray (int [,] collection)
{
    for (i = 0; i < collection.GetLength(0); i++)
    {   
        for (j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(10, 100);
        }
    }
    Console.WriteLine($" {i}  {j}");
}

void Choice(int i, int j)
{
    Console.WriteLine($"Choice {i}  {j}");
    if (i == j)
    {
        sumElem(array);
    }
    else
    {
        Console.WriteLine("массив должен быть с одинаковым количеством строк и стобцов!");
    }
}

void PrintArray (int [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0,15}", collection[i, j]);
        }
    Console.WriteLine();
    }
}

void sumElem(int[,] array)
{  
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {   
                if (i == j)
                {
                    sum = sum + array[i,j];             
                }
            }        
        }
        Console.WriteLine($"Сумма элементов главной диагонали == {sum}");
}

FillArray(array);
PrintArray(array);
Choice(i, j);

// В двумерном массиве n×k заменить четные элементы на противоположные


double[,] mass = new double[4, 4];    
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
    {   
         for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(-100,100) / 10.00;
                    Console.Write("{0,15}", mass[i, j]);
                }
                Console.WriteLine();
    }

for (int i = 0; i < mass.GetLength(0); i++)
    {   
         for (int j = 0; j < mass.GetLength(1); j++)
                {   
                    Console.WriteLine(mass[i, j] % 2 + " ");
                    if (mass[i, j] % 2 < 0.000000000000001 && mass[i,j] % 2)
                        {
                            mass[i,j] = -mass[i,j];
                        } 
                
                }
    }
Console.WriteLine();

void PrintArray (double [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0,15}", collection[i, j]);
            //Console.Write($"{collection[i, j]}  ");
        }
    Console.WriteLine();
    }
}

PrintArray(mass);
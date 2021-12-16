// Показать двумерный массив размером m×n заполненный целыми числами

int[,] mass = {{1, 2, 3, 4}, {5, 6, 7, 8}};

for (int i = 0; i < mass.GetLength(0); i++)
    {   
         for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write("{0,3}", mass[i, j]);
                }
                Console.WriteLine();
    }
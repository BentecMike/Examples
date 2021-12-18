// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] mass = new double[4, 4];    //{{1, 2, 3, 4}, {-5, -6, -7, -8}};
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
    {   
         for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(-100,100) / 10.0;
                    Console.Write("{0,15}", mass[i, j]);
                }
                Console.WriteLine();
    }

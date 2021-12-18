// В двумерном массиве показать позиции числа, заданного пользователем или указать,
// что такого элемента нет

Console.WriteLine("Введите искомое число: ");
int a = int.Parse(Console.ReadLine());
int t = 0; //счетчик

int[,] mass = new int[5, 5];    
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
    {   
         for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(0,10);
                    Console.Write("{0,10}", mass[i, j]);
                }
                Console.WriteLine();
    }

for (int i = 0; i < mass.GetLength(0); i++)
    {    
         for (int j = 0; j < mass.GetLength(1); j++)
                {   
                    if (a == mass[i,j])
                    {
                        Console.WriteLine($"Позиция искомого числа: ({a}) в массиве {i}  {j}");
                        t++;               
                    }
                    // else
                    // {
                    //     Console.WriteLine("Искомое число не найдено!");
                    // }
                }  
    }
    if (t == 0)
          Console.WriteLine("Искомое число не найдено в массиве!");
Console.WriteLine();

// void PrintArray (int[,] collection)
// {
//     for(int i = 0; i < collection.GetLength(0); i++)
//     {
//         for(int j = 0; j < collection.GetLength(1); j++)
//         {
//             Console.Write("{0,10}", collection[i, j]);
//             //Console.Write($"{collection[i, j]}  ");
//         }
//     Console.WriteLine();
//     }
// }

//PrintArray(mass);
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] array = {0,1,1,1,0,0,1,0};
int i = 0;
int count = array.Length;
while ( i < count)
{
    Console.Write($"{array[i]} ");
    i++;
}

/*

 int m = 8;
            Random rnd = new Random();
            int[] arr = new int[m];
 
            while (arr.Count(r => r == 1) < arr.Count() / 2)
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = rnd.Next(0, 2);
 
            foreach (int i in arr)
                Console.Write(string.Format("{0,2} ", i));
 
            Console.WriteLine();
            Console.ReadKey();
            */
// Написать программу копирования массива

int [] array = {1, 2, 5, 8, 6};

int [] anotherArray = new int[5];

Array.Copy(array, anotherArray, array.Length); //Метод копирования массива


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + "-" + anotherArray[i]);
}

anotherArray[3] = 7;

Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + "-" + anotherArray[i]);
}
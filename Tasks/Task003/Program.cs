//Даны два числа. Показать большее и меньшее число
int number1 = new Random().Next(1, 20);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 20);
Console.WriteLine(number2);


if (number1 > number2)
    Console.WriteLine("Число 1 больше числа 2");
else
    Console.WriteLine("Число 2 больше числа 1");
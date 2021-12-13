// Найти третью цифру числа или сообщить, что её нет

int a = new Random().Next(20, 999);
Console.WriteLine(a);
//Console.WriteLine(a % 10);
int a3 = a % 10;
Console.WriteLine(a % 100 / 10);
int a2 = a % 100 / 10;
Console.WriteLine(a % 1000 / 100);
int a1 = a % 1000 / 100;
Console.WriteLine(a1);

    if (a1 == 0 && a2 >= 0 && a3 >= 0) 
             Console.WriteLine("Третьей цифры нет");
    else
            Console.WriteLine($"{a1} {"третья цифра числа"}");


if (a1 >= 0 && a2 >= 0 && a3 == 0) 
             Console.WriteLine("Третьей цифры нет");
    else
            Console.WriteLine($"{a3} {"третья цифра числа"}");
// Выяснить, кратно ли число заданному, если нет, вывести остаток

int a = new Random().Next(2, 10);
    Console.WriteLine(a);
int b = new Random().Next(10, 20);
    Console.WriteLine(b);
    float c = b % a;
    Console.WriteLine(c);

if (c == 0)
       Console.Write($"{a} {"является кратным"} {b}"); //$"Имя: {name}  Возраст: {age}  Рост: {height}м");
else
    Console.WriteLine($"{c} {"остаток от деления"}");
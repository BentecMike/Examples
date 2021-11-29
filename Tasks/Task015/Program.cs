// Дано число. Проверить кратно ли оно 7 и 23 (1288 кратно)

int a = 1288; // new Random().Next(7, 999);
Console.WriteLine(a);
int b = a % 7;
Console.WriteLine(b);
int c = a % 23;
Console.WriteLine(c);

if (b == 0 && c == 0)
Console.WriteLine($"{a} {"кратно 7 и 23"}");
else 
Console.WriteLine($"{a} {"некратно 7 и 23"}");
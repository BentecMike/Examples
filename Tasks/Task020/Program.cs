// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четвети (0, 1, 2, 3, 4): ");
int q = new Random().Next(0, 5);
Console.WriteLine(q);

if (q == 1)
Console.WriteLine("x > 0 и у > 0");
if (q == 2)
Console.WriteLine("x < 0 и y > 0");
if (q == 3)
Console.WriteLine("x < 0 и y < 0");
if (q == 4)
Console.WriteLine("x > 0 и y < 0");
if (q == 0)
Console.WriteLine("x = 0 и y = 0");

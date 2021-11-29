// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next (10, 99);
Console.WriteLine(a);

int a1 = a % 10;
Console.WriteLine(a1);
int a2 = a % 100/10;
Console.WriteLine(a2);
if (a1 > a2)
Console.WriteLine("Наибольшее число из двух: " + a1);
else 
Console.WriteLine("Наибольшее число из двух: " + a2);
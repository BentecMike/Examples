// Программа проверяет пятизначное число на палиндромом

Console.Write("Введите пятизначное число: ");
string q = Console.ReadLine();
int a = int.Parse(q[0].ToString());
int b = int.Parse(q[1].ToString());
int c = int.Parse(q[2].ToString());
int d = int.Parse(q[3].ToString());
int e = int.Parse(q[4].ToString());

if (a == e && b == d)
Console.WriteLine($"{q} {"является палиндромом"}");
else
Console.WriteLine($"{q} {"не является палиндромом"}");

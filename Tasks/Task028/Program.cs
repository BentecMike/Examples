// Подсчитать сумму цифр в числе

Console.WriteLine($"Введите число: ");
int A = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i < A; i++)
{
    int result1 = A % 10; 
    int result2 = A % 100/10;
    int result3 = A % 1000/100;
    int result4 = A % 10000/1000;
    int result5 = A % 100000/10000;
    result = result1 + result2 + result3 + result4 + result5;
    i++;
}
Console.WriteLine(result);
 //Console.WriteLine(result);
/*

int a = Convert.ToInt32(new Random().Next (100, 999));
 Console.WriteLine(a);
     Console.WriteLine(a % 10);
     int a3 = a % 10;
     Console.WriteLine(a % 100/10);
     int a2 = a % 100/10;
     Console.WriteLine(a % 1000/100);
     int a1 = a % 1000/100;
     Console.Write(a1);
    Console.Write(a3);
    */
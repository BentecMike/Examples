// Определить количество цифр в числе

Console.WriteLine($"Введите число: ");
int A = int.Parse(Console.ReadLine());
int i = 0;
int result;
while (A > 0)
    {
       result = A /= 10; 
       i++;
    }              
Console.WriteLine(i);

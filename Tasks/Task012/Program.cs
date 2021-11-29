// Удалить вторую цифру трёхзначного числа

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
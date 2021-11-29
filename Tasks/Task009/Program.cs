//Показать последнюю цифру трёхзначного числа

 int a = Convert.ToInt32(new Random().Next (100, 999));
 Console.WriteLine(a);
     Console.WriteLine(a % 10);


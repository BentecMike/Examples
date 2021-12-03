// Найти расстояние между точками в пространстве 2D/3D (AB = √(xb - xa)2 + (yb - ya)2) //(AB = √(xb - xa)2 + (yb - ya)2)

double x1 = new Random().Next(-10, 11);
double y1 = new Random().Next(-10, 11);
//double z1 = new Random().Next(-10, 11);
Console.WriteLine($"{x1} {y1}");
//Console.WriteLine($"{x1} {y1} {z1}");

double x2 = new Random().Next(-10, 11);
double y2 = new Random().Next(-10, 10);
//double z2 = new Random().Next(-10, 11);
Console.WriteLine($"{x2} {y2}");
//Console.WriteLine($"{x2} {y2} {z2}");

double x = Math.Pow((x2-x1),2);
double y = Math.Pow((y2-y1),2); 
//double z = Math.Pow((z2-z1),2); 
double XY = Math.Sqrt(x + y);
//double XYZ = Math.Sqrt(x + y + z);
Console.WriteLine(XY);
//Console.WriteLine(XYZ);
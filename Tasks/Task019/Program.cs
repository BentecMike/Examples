// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = -5;
int y = -6;

if (x > 0 && y > 0)
Console.WriteLine("I четверть плоскости");
if (x < 0 && y > 0)
Console.WriteLine("II четверть плоскости");
if (x < 0 && y < 0)
Console.WriteLine("III четверть плоскости");
if (x > 0 && y < 0)
Console.WriteLine("IV четверть плоскости");
else 
Console.WriteLine("Точка начала координат");

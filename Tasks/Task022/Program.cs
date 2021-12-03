// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
int x1 = new Random().Next(-10, 11);
Console.Write(x1);
int y1 = new Random().Next(-10, 11);
Console.Write(y1);

int x2 = new Random().Next(-10, 11);
Console.Write(x2);
int y2 = new Random().Next(-10, 10);
Console.Write(y2);

int rx;
int ry;

if (x1 <= x2 && y1 <= y2)
    {
        rx = 0;

    }

/*if (x1 == x2 && y1 != y2)
  {  rx = 0;
     ry = Math.Abs(y1) + Math.Abs(y2);
    Console.WriteLine($"{"Расстояние между точками x ="} {rx} {"y ="} {ry}");
  }
if (x1 != x2 && y1 == y2)
  {  rx = Math.Abs(x1) + Math.Abs(x2);;
     ry = 0;
    Console.WriteLine($"{"Расстояние между точками x ="} {rx} {"y ="} {ry}");
  }
else
    rx = Math.Abs(x1) + Math.Abs(x2);
    ry = Math.Abs(y1) + Math.Abs(y2);
    Console.WriteLine($"{"Расстояние между точками x ="} {rx} {"y ="} {ry}");
    */
/*Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while (count < 2000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count ++;

}
*/
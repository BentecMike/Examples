// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool x = true;
bool y = false;
bool a = !(x ^ y);
bool b = !x & !y;
Console.WriteLine(a = b);
 static Boolean methodB (bool x = false, bool y = false)
{
    bool a = !(x ^ y);
    bool b = !x & !y;
    Console.WriteLine(a = b);
    return a = b;
}
methodB(false, true);

methodB(false, false);

methodB(true, true);





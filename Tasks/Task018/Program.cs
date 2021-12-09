// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


static Boolean methodB(bool x = false, bool y = false)
{
    return !(x || y) == (!x && !y);
}

if (methodB(false, true) && methodB(false, false) && methodB(true, true) && methodB(true, false))
{
    Console.WriteLine("правдиво для всех наборов выражений");
}
else
{
    Console.WriteLine("ложно");
}

//доделать


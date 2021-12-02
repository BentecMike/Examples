// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool x = false;
bool y = false;
bool a = !(x ^ y);
bool b = !x & !y;
Console.WriteLine(a = b);


    



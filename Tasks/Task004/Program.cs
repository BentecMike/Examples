//По заданному номеру дня недели вывести его название
int day = new Random().Next(1, 8);
Console.WriteLine(day);

if (day == 1)
    Console.WriteLine("Сегодня Понедельник");
if (day == 2)
    Console.WriteLine("Сегодня Вторник");
if (day == 3)
    Console.WriteLine("Сегодня Среда");
if (day == 4)
    Console.WriteLine("Сегодня Четверг");
if (day == 5)
    Console.WriteLine("Сегодня Пятница");
if (day == 6)
    Console.WriteLine("Сегодня Суббота");
if (day == 7)
    Console.WriteLine("Сегодня Воскресенье");
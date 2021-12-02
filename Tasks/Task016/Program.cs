// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int day = new Random().Next(1, 8); //ноябрь 2021 - 30 дней
Console.WriteLine(day);

if (day == 7 || day == 6)
    Console.WriteLine("Сегодня выходной день");
else
    Console.WriteLine("Сегодня будний день");

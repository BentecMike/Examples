// Найти максимальное из трех чисел
int numa = new Random().Next(1, 1000);
Console.WriteLine(numa);
int numb = new Random().Next(1, 1000);
Console.WriteLine(numb);
int numc = new Random().Next(1, 1000);
Console.WriteLine(numc);

int max = numa;

if (numb > max) max = numb;
if (numc > max) max = numc;
Console.WriteLine(max);
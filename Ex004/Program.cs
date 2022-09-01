// Найти максимальное из трех чисел

Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>a && b>c)
{
    max = b;
    Console.WriteLine("Максимальное число:" + max);
}
else if (c>a && c>b)
{
    max=c;
    Console.WriteLine("Максимальное число:" + max);
}
else 
Console.WriteLine("Максимальное число:" + max);


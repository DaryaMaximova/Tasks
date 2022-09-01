// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (b > a)
{
    max = b;
    Console.WriteLine("Большее число:" + max);
}
else
{
    Console.WriteLine("Большее число:" + max);
}

if (a < b)
    {
        min = a;
        Console.WriteLine("Меньшее число:" + min);
    }
else 
    {
        Console.WriteLine("Меньшее число:" + min);
    }


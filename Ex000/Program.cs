// Вывести квадрат числа

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Square()
{
int result = N * N;
Console.WriteLine("Квадрат числа:" + result);
}
Square();
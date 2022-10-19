int SumSeries(int n, int m)
{
    if (n == m) return m;
    return n + SumSeries(n + 1, m);
}

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(SumSeries(n, m));
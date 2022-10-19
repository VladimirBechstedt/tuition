string row(int a)
{
    if (a == 1) return "1";
    return Convert.ToString(a) + ", " + Convert.ToString(row(a - 1));
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(row(num));
Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num > 999)
{
    while (num > 999)
    {
        num /= 10;
    }
    int a = num % 10;
    Console.WriteLine(a);
}
else
{
    int a = num % 10;
    Console.WriteLine(a);
}

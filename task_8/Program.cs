Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (num < 1)
{
    Console.WriteLine("Число должно быть положительным");
}
if (num > 1)
{
    while (i < num + 1)
    {
        Console.Write($"{i}, ");
        i += 2;
    }
}
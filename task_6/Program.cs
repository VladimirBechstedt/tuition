Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.Write("Нет");
}
else
{
    Console.Write("Да");
}
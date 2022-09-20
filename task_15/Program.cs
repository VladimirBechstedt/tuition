Console.Clear();
Console.Write("Введите день недели: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 | num == 7)
{
    Console.Write("Да");
}
else if (num > 0 & num < 6)
{
    Console.Write("Нет");
}

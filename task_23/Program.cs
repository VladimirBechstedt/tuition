Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= num)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}

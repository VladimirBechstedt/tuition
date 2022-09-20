Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 | num > 999)
{
    bool i = true;

    while (i)
    {
        Console.Clear();
        Console.Write("Введите трехзначное число: ");

        num = Convert.ToInt32(Console.ReadLine());

        if (num > 99 & num < 1000)
        {
            i = false;
        }
        else
        {
            //Console.Write("Введите трехзначное число: ");
        
        }
    }
}

int a = num % 100;
int b = a / 10;

Console.WriteLine(b);
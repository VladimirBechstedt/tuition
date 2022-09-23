Console.Clear();
Console.Write("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 | num > 99999)
{
    bool i = true;

    while (i)
    {
        Console.Clear();
        Console.Write("Введите пятизначное число: ");

        num = Convert.ToInt32(Console.ReadLine());

        if (num > 9999 & num < 100000)
        {
            i = false;
        }
        
    }
}

int [] res = new int [5];
res[0] = num / 10000;
res[1] = num % 10000 / 1000;
res[2] = num % 1000 / 100;
res[3] = num % 100 / 10;
res[4] = num % 10;

if (res[0] == res[4] & res[1] == res[3]) Console.WriteLine("Да");
else Console.WriteLine("Нет");
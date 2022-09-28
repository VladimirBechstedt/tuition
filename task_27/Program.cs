Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

bool a = true;
int sum = 0;

while (a)
{
    if(num / 10 == 0)
    {
        a = false;
    }
    sum = sum + (num % 10);
    num = num / 10;

}
Console.WriteLine(sum);

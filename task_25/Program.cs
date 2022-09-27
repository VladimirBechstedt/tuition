Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;

for(int i = 1; i < b; i++)
{
    num = num * a;
}
Console.WriteLine(num);
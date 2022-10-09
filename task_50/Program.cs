int[,] RandomArr(int start, int end)
{
    int[,] arr = new int[6, 7];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, end + 1);
        }
    }
    return arr;
}

int[,] arr = RandomArr(0, 99);

Console.Write("Введите цифру: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        if(arr[i, j] == a) b++;
    }
}

if(b >= 1) Console.Write("Такое число есть");
else Console.Write("Такого числа нет");

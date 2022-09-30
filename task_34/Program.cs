Console.Clear();

void PrintArr(int[] value)
{
    for (int i = 0; i < value.Length; i++)
    {
        Console.Write(value[i]+ " ");
    }
    Console.WriteLine();
}

int[] RandomArr(int start, int end, int LenghtArr)
{
    int[] arr = new int[LenghtArr];
    for(int i = 0; i < LenghtArr; i++)
    {
        arr[i] = new Random().Next(start, end + 1);
    }
    return arr;
}

int[] arr = RandomArr(100, 999, 12);
PrintArr(arr);

int even = 0;
int odd = 0;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0) even++;
    else odd++;
}
Console.WriteLine(even);
Console.WriteLine(odd);
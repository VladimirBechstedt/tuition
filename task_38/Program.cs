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

int[] arr = RandomArr(0, 1000, 10);
int min = arr[0];
int max = arr[0];

for(int i = 1; i < arr.Length; i++)
{
    if(min > arr[i]) min = arr[i];
    if(max < arr[i]) max = arr[i];
}
PrintArr(arr);
Console.WriteLine(max - min);
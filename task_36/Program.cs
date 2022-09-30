int[] RandomArr(int start, int end, int LenghtArr)
{
    int[] arr = new int[LenghtArr];
    for(int i = 0; i < LenghtArr; i++)
    {
        arr[i] = new Random().Next(start, end + 1);
    }
    return arr;
}

int[] arr = RandomArr(-99, 99, 10);
int sum = 0;

for(int i = 1; i < arr.Length; i = i + 2)
{
    sum = sum + arr[i];
}
Console.WriteLine(sum);
void PrintArr(int[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            Console.Write(value[i, j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RandomArr(int start, int end)
{
    int[,] arr = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, end + 1);
        }
    }
    return arr;
}

int[,] arr = RandomArr(0, 9);
PrintArr(arr);

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {   
        for(int p = 0; p < arr.GetLength(1) - 1; p++)
        {    
            if(arr[i, j] > arr[i, p]) (arr[i, j], arr[i, p]) = (arr[i, p], arr[i, j]);
        }
    }
}
PrintArr(arr);
